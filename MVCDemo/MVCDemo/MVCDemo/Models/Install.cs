﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniProfilerDemo.Models
{
    public class Install
    {
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)]//不自动增长
        public int ID { get; set; }
        public string City { get; set; }
        public string Type { get; set; }

        public Install(int ID,string City,string Type)
        {
            this.ID = ID;
            this.City = City;
            this.Type = Type;
        }

        public Install() { }
    }
}
