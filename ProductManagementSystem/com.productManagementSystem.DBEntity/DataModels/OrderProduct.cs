using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace com.productManagementSystem.DBEntity.DataModels;

[Table("Order_Product")]
public partial class OrderProduct
{
    [Key]
    public int Id { get; set; }

    public int? OrderId { get; set; }

    public int? ProductId { get; set; }

    public int? Quantity { get; set; }

    public int? Price { get; set; }

    [Column(TypeName = "timestamp without time zone")]
    public DateTime? DeliveryDate { get; set; }

    [ForeignKey("OrderId")]
    [InverseProperty("OrderProducts")]
    public virtual Order? Order { get; set; }

    [ForeignKey("ProductId")]
    [InverseProperty("OrderProducts")]
    public virtual Product? Product { get; set; }
}
