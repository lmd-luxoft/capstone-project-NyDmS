using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Ef
{
    //Отдельные атрибуты избыточны они для примера

    [Table("Account")]
    public class Account
    {
        [Key]
        public int Id { get;set; }
        [Required]
        [Column(TypeName = "datetime")]
        public System.DateTime CreateDate { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string Name { get; set; }
        [Required]
        public int Balance { get; set; }       
    }
}