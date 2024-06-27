using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace com.productManagementSystem.DBEntity.DataModels;

[Table("Supplier")]
public partial class Supplier
{
    [Key]
    public int Id { get; set; }

    [Column(TypeName = "character varying")]
    public string? FirstName { get; set; }

    [Column(TypeName = "character varying")]
    public string? LastName { get; set; }

    [Column(TypeName = "character varying")]
    public string? ContactNumber { get; set; }

    [Column(TypeName = "character varying")]
    public string? Address { get; set; }

    [Column(TypeName = "character varying")]
    public string? City { get; set; }

    public bool? Isdeleted { get; set; }

    [Column(TypeName = "timestamp without time zone")]
    public DateTime? CreatedDate { get; set; }

    [Column(TypeName = "timestamp without time zone")]
    public DateTime? ModifiedDate { get; set; }

    [InverseProperty("Supplier")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
