using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace com.productManagementSystem.DBEntity.DataModels;

[Table("Category")]
public partial class Category
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "character varying")]
    public string? Name { get; set; }

    public bool? Isdeleted { get; set; }

    [Column(TypeName = "timestamp without time zone")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "timestamp without time zone")]
    public DateTime? ModifiedDate { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
