using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Bangazon.Models
{
  public class Order
  {
    [Key]
    public int OrderId {get;set;}

    [Required]
    [DataType(DataType.Date)]
    [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
    public DateTime DateCreated {get;set;}

    
    [DataType(DataType.Date)]
    public DateTime? DateCompleted {get;set;}

    // Foreign key reference to the Species table
    public int CustomerId {get;set;}
    public Customer Customer {get;set;}

    public int? PaymentTypeId {get;set;} //FK
    public PaymentType PaymentType {get;set;} //TABLE

    public ICollection<LineItem> LineItems;
  }
}