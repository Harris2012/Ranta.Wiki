﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由EntityGen生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ranta.Repository.WikiDB.Entity
{
    [Table("Blog")]
    public partial class BlogEntity
    {

        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string PostEname { get; set; }

        [Required]
        [StringLength(200)]
        public string PostTitle { get; set; }

        [Required]
        public string PostBody { get; set; }

        [Required]
        public string Html { get; set; }

        public int DataStatus { get; set; }

        [Required]
        [StringLength(32)]
        public string CreateBy { get; set; }

        public DateTime CreateTime { get; set; }

        [Required]
        [StringLength(32)]
        public string LastUpdateBy { get; set; }

        public DateTime LastUpdateTime { get; set; }
    }
}