﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace Memberships.Entities
{
    [Table("SubscriptionProduct")]
    public class SubscriptionProduct
    {
        [Required]
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }

        [Required]
        [Key, Column(Order = 2)]
        public int SubscriptionId { get; set; }
        

        //This will not mapped to the database!
        [NotMapped]
        public int OldProductId { get; set; }
        [NotMapped]
        public int OldSubscriptionId { get; set; }
    }
}