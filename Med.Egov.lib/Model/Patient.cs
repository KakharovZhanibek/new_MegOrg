﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med.Egov.lib.Model
{
    public class Patient
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string middlename { get; set; }

        public string IIN_;
        public string IIN
        {
            get
            {
                return IIN_;
            }
            set
            {
                if (value.Length != 12)
                {
                    throw new ArgumentException("Введите корректный ИИН!");
                }
                IIN_ = value;
            }
        }
        public MedOrg medOrg { get; set; } = null;
    }
}
