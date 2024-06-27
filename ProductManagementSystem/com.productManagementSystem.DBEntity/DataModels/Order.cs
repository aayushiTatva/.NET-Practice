using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace com.productManagementSystem.DBEntity.DataModels;

[Table("Order")]
public partial class Order
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "timestamp without time zone")]
    public DateTime? OrderDate { get; set; }

    public bool? Isdeleted { get; set; }

    [Column(TypeName = "timestamp without time zone")]
    public DateTime? ModifiedDate { get; set; }

    [InverseProperty("Order")]
    public virtual ICollection<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
}
