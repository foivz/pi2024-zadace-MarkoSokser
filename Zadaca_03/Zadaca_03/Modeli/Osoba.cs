﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca_03.Modeli
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Password { get; set; }

        public string Kor_Ime { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
           
        }
    }
}

