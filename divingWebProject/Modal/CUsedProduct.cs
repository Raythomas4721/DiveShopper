using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divingWebProject.Modal
{
    public class CUsedProduct
    {

        public int productId { get; set; }
        public int sellerId { get; set; }
        public int categoryId { get; set; }
        public string productName { get; set; }
        public string productDescription { get; set; }
        public decimal productPrice { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
        public int productConditionId { get; set; }
        public bool productStatus { get; set; }
    }
}
