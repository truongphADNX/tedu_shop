﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TeduShop.Model.Abstract;

namespace TeduShop.Model.Models
{
    internal class Order : AuditableSmall
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required, MaxLength(256)]
        public string CustomerName { get; set; }
        [Required, MaxLength(256)]
        public string CustomerAddress { get; set; }
        [Required, MaxLength(256)]
        public string CustomeEmail { get; set; }
        [Required, MaxLength(50)]
        public string CustomeMobile { get; set; }
        [Required, MaxLength(256)]
        public string CustomerMessage { get; set; }
        [MaxLength(256)]
        public string PaymentMethod { get; set; }

        public string PaymentStatus { get; set; }

        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }

    }
}
