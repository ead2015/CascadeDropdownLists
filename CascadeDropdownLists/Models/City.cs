﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CascadeDropdownLists.Models
{
    public class City
    {

        public City()
        { }

        public City(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
    }
}