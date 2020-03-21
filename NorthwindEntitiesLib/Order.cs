using System;
using System.Collections.Generic;

namespace Library
{
    public class Order
    {
        public int OrderId {get;set;}
        public string CustomerId {get;set;}
        public int EmployeeID {get;set;}
        public DateTime? OrderDate {get;set;}
        public DateTime? RequiredDate {get;set;}
        public DateTime? ShippedDate {get;set;}
        public int ShipVia {get;set;}
        public decimal? Freight {get;set;} = 0;
        public Customer Customer {get;set;}
        public Employee Employee {get;set;}
        public Shipper Shipper {get;set;}
        public ICollection<OrderDetail> OrderDetails {get;set;}
    }
}