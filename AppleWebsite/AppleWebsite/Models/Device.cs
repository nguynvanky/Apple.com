using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AppleWebsite.Models
{
	public class Device
	{
        [Key]
        public int id_dev { get; set; }
        public string name_dev { get; set; }
        public double cost { get; set; }
        public string img { get; set; }
        public string storage { get; set; }
        public int id_cate { get; set; }
        public virtual Category Category { get; set; }
    }
}