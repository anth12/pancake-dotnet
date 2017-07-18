using System;
using System.Collections.Generic;
using System.Text;

namespace Pancake.Tests.Models
{
    internal class Sale
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public List<SaleItem> Items { get; set; }

        public decimal Tax { get; set; }
        public decimal Total { get; set; }
    }

    internal class SaleItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public TaxType Tax { get; set; }
    }

    internal enum TaxType
    {
        Except,
        Regional,
        National
    }
}
