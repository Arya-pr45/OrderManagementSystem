﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Models
{
    // Represents a shopping cart
    public class Cart
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]

        public bool IsCheckedOut { get; set; } = false;

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public DateTime UpdatedAt { get; set; }

        public ICollection<CartItem> Items { get; set; } = new List<CartItem>();  
    }
}