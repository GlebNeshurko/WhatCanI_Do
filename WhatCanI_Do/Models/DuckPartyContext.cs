using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WhatCanI_Do.Models
{
    public class DuckPartyContext : DbContext
    {
        public DbSet<DuckParty> DuckPartySet { get; set; }
    }
}