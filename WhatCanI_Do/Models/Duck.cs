﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.Linq;

namespace WhatCanI_Do.Models
{
    public class Duck 
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int Money { get; set; }
    }
}