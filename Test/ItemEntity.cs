﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Test
{
    class ItemEntity
    {
        private String name, parameter, enable;

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public String getParameter()
        {
            return parameter;
        }

        public void setParameter(String parameter)
        {
            this.parameter = parameter;
        }

        public String getEnable()
        {
            return enable;
        }

        public void setEnable(String enable)
        {
            this.enable = enable;
        }
    }
}
