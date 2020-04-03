using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_Exam.Models
{
    public class Category
    {

        [Key]
        [DisplayName("Category ID")]

        public int CategoryID { get; set; }

        [DisplayName("Category Name")]

        public string CategoryName { get; set; }

        [DisplayName("Description")]

        public string Description { get; set; }

        [DisplayName("Picture")]

        public string Picture { get; set; }

        public virtual List<Product> Product { get; set; }
    }
}