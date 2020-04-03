using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_Exam.Models
{
    public class Product
    {
        [Key]

        [Required]
        [DisplayName("Product ID")]
        public int ProductID { get; set; }

        [DisplayName("Product Name")]
        [StringLength(20, MinimumLength =5, ErrorMessage ="Minimum length is 5")]
        public string ProductName { get; set; }

        [DisplayName("Supplier ID")]
        [Required]
        public int SupplierID { get; set; }

        [DisplayName("Category ID")]
        [Required]
        public int CategoryID { get; set; }

        [DisplayName("Quantity Per Unit")]

        public int QuantityPerUnit { get; set; }

        [DisplayName("Unit Price")]

        public decimal UnitPrice { get; set; }

        [DisplayName("unit sln Stock")]

        public string UnitslnStock { get; set; }

        [DisplayName("Units On Order")]

        public int UnitsOnOrder { get; set; }

        [DisplayName("Reorder Level")]

        public int ReorderLevel { get; set; }

        [DisplayName("Discontinued")]

        public string Discontinued { get; set; }

        public virtual Category Category { get; set; }
    }
}