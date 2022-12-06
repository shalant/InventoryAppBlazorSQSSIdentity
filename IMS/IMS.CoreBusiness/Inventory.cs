﻿using System.ComponentModel.DataAnnotations;

namespace IMS.CoreBusiness
{
    public class Inventory
    {
        public int InventoryId { get; set; }

        [Required]
        [StringLength(150)]
        public string InventoryName { get; set; } = string.Empty;

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater than or equal to zero")]
        public int Quantity { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Quantity must be greater than or equal to zero")]
        public double Price { get; set; }
    }
}