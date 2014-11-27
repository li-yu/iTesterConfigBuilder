using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Test
{
    public partial class Main : Form
    {
        #region Constructions

        public Main()
        {
            InitializeComponent();
        }

        #endregion

        #region Variables

        private DataTable dtSource;
        private int selectionIdx = 0;
        private List<ItemEntity> mEntity = new List<ItemEntity>();

        #endregion

        #region 控件事件

        private void FrmDGVRowMove_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void btnInitData_Click(object sender, EventArgs e)
        {
            dtSource.Clear();
            InitData();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedCells.Count > 0)
            {
                List<DataGridViewRow> dgvrc = new List<DataGridViewRow>();

                DataGridViewRow dgvr;

                if (MessageBox.Show("确定删除？", "删除确认", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    foreach (DataGridViewCell dgvc in dgv.SelectedCells)
                    {
                        dgvr = dgv.Rows[dgvc.RowIndex];
                        if (!dgvrc.Contains(dgvr))
                        {
                            dgvrc.Add(dgvr);
                        }
                    }
                    foreach (DataGridViewRow dr in dgvrc)
                    {
                        dgv.Rows.Remove(dr);
                    }
                    dgv.Refresh();
                }
            }
            else
            {
                MessageBox.Show("请选择一条或多条记录");
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region dgv行拖动功能

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.Rows.Count > 0 && selectionIdx > -1 && selectionIdx < dgv.Rows.Count - 1)// (dgv.SelectedRows.Count > 0))
            {

                if (dgv.Rows.Count <= selectionIdx)
                    selectionIdx = dgv.Rows.Count - 1;
                dgv.Rows[selectionIdx].Selected = true;
                //dgv.CurrentCell = dgv.Rows[selectionIdx].Cells[0];
            }
        }

        private void dgv_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
                selectionIdx = e.RowIndex;
        }

        private void dgv_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            if ((e.Clicks < 2) && (e.Button == MouseButtons.Left))
            {
                if ((e.ColumnIndex == -1) && (e.RowIndex > -1))
                    dgv.DoDragDrop(dgv.Rows[e.RowIndex], DragDropEffects.Move);
            }
        }

        private void dgv_DragDrop(object sender, DragEventArgs e)
        {
            int idx = GetRowFromPoint(e.X, e.Y);
            if (idx < 0) return;

            if (e.Data.GetDataPresent(typeof(DataGridViewRow)))
            {
                DataGridViewRow row = (DataGridViewRow)e.Data.GetData(typeof(DataGridViewRow));
                DataRow ddr = ((DataRowView)row.DataBoundItem).Row;
                DataRow nr = ((DataTable)dgv.DataSource).NewRow();

                for (int i = 0; i < row.Cells.Count; i++)
                {
                    nr[i] = row.Cells[i].Value;
                }
                selectionIdx = idx;
                ((DataTable)dgv.DataSource).Rows.InsertAt(nr, idx);
                ((DataTable)dgv.DataSource).Rows.Remove(ddr);
                dgv.ClearSelection();
            }
        }

        private void dgv_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private int GetRowFromPoint(int x, int y)
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                Rectangle rec = dgv.GetRowDisplayRectangle(i, false);

                if (dgv.RectangleToScreen(rec).Contains(x, y))
                    return i;
            }

            return -1;
        }

        #endregion

        #region Common Functions

        private void InitData()
        {
            if (!File.Exists("config.xml")) 
            {
                MessageBox.Show("找不到初始化配置档！", "ERROR");
                this.Close();
                return;
            }
            loadXML();

            dtSource = new DataTable();
            dtSource.Columns.Add("Item");
            dtSource.Columns.Add("Parameter");
            dtSource.Columns.Add(new DataColumn("Enable", typeof(bool)));
       

            for (int i = 0; i < mEntity.Count; i++)
            {
                DataRow dr = dtSource.NewRow();
                dr.BeginEdit();
                dr["Item"] = mEntity[i].getName();
                dr["Parameter"] = mEntity[i].getParameter();
                dr["Enable"] = mEntity[i].getEnable();
                dr.EndEdit();
                dtSource.Rows.Add(dr);
            }

            dgv.DataSource = dtSource;
       
        }

        #endregion


        private void loadXML() 
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("config.xml");
            XmlNode xn = xmlDoc.SelectSingleNode("TabletTest");
            XmlElement xe = (XmlElement)xn;
            textBox_language.Text = xe.GetAttribute("Language");
            textBox_externalSD.Text = xe.GetAttribute("ExternalSDPath");
            textBox_wifiSSID.Text = xe.GetAttribute("WiFiSSID");
            textBox_wifiPW.Text = xe.GetAttribute("WiFiPassWord");
            textBox_wifimac.Text = xe.GetAttribute("WiFiAddressStart");
            textBox_btmac.Text = xe.GetAttribute("BTAddressStart");
            textBox_imei.Text = xe.GetAttribute("IMEIStart");
            textBox_imageversion.Text = xe.GetAttribute("ImageVersion");
            XmlNodeList xnl = xn.ChildNodes;
            for (int i = 0; i < xnl.Count;i++ )
                {
                    XmlNode xnf = xnl[i];
                    ItemEntity ie = new ItemEntity();
                    XmlElement xe2 = (XmlElement)xnf;
                    ie.setName(xe2.GetAttribute("name"));
                    ie.setEnable(xe2.GetAttribute("enable"));
                    ie.setParameter(xe2.GetAttribute("parameter"));
                    mEntity.Add(ie);
                }
            
        }

        private void CreateXML() 
        {
            XmlDocument xmlDoc = new XmlDocument();
            //创建类型声明节点  
            XmlNode node = xmlDoc.CreateXmlDeclaration("1.0", "utf-8", "");
            xmlDoc.AppendChild(node);
            //创建根节点  
            XmlNode root = xmlDoc.CreateElement("TabletTest");
            XmlElement xe = (XmlElement)root;
            xe.SetAttribute("Language",textBox_language.Text);
            xe.SetAttribute("ExternalSDPath", textBox_externalSD.Text);
            xe.SetAttribute("WiFiSSID",textBox_wifiSSID.Text);
            xe.SetAttribute("WiFiPassWord", textBox_wifiPW.Text);
            xe.SetAttribute("WiFiAddressStart",textBox_wifimac.Text);
            xe.SetAttribute("BTAddressStart", textBox_btmac.Text);
            xe.SetAttribute("IMEIStart", textBox_imei.Text);
            xe.SetAttribute("ImageVersion", textBox_imageversion.Text);
            xmlDoc.AppendChild(xe);

            for (int i = 0; i < dgv.RowCount; i++) 
            {
                XmlNode node1 = xmlDoc.CreateNode(XmlNodeType.Element, "Item", null);
                XmlElement xe1 = (XmlElement)node1;
                xe1.SetAttribute("name", dgv.Rows[i].Cells[0].Value.ToString());
                xe1.SetAttribute("enable", dgv.Rows[i].Cells[2].Value.ToString());
                xe1.SetAttribute("parameter", dgv.Rows[i].Cells[1].Value.ToString());
                root.AppendChild(xe1);
            }

            try
            {
                xmlDoc.Save("temp.xml");
            }
            catch (Exception e)
            {
                //显示错误信息  
                MessageBox.Show(e.Message, "ERROR");
            }  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateXML();
            ShowSaveFileDialog();
        }

        private void ShowSaveFileDialog()
        {
             
            SaveFileDialog sfd = new SaveFileDialog();

            sfd.FileName = "iTester";
            //设置文件类型   
            sfd.Filter = "xml文件（*.xml）|*.xml";

            //设置默认文件类型显示顺序   
            sfd.FilterIndex = 1;

            //保存对话框是否记忆上次打开的目录   
            sfd.RestoreDirectory = true;

            //点了保存按钮进入   
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString();     //获得文件路径 
                File.Copy("temp.xml", localFilePath, true);
                File.Delete("temp.xml");
                MessageBox.Show("保存成功!", "Notice");
                
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://liyuyu.cn/upload/itester.html"); 
        }

    }
}