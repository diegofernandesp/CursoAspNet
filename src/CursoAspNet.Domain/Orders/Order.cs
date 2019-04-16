using CursoAspNet.Domain.Items;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAspNet.Domain.Orders
{
    public class Order : Entity
    {
        public Item Item { get; private set; }
        public string Nuor { get; private set; }
        public DateTime Dorg { get; private set; }
        public DateTime Dtrc { get; private set; }
        public Double Qtnc { get; private set; }

        private Order()
        {
        }
        public Order (string nuor, Item item, DateTime dorg, DateTime dtrc, Double qtnc)
        {
            Validate(nuor, qtnc, item);
            SetValues(nuor, item, dorg, dtrc, qtnc);
        }

        public void Update (string nuor, Item item, DateTime dorg, DateTime dtrc, Double qtnc)
        {
            Validate(nuor, qtnc, item);
            SetValues(nuor, item, dorg, dtrc, qtnc);
        }

        private void SetValues(string nuor, Item item, DateTime dorg, DateTime dtrc, double qtnc)
        {            
            Nuor = nuor;
            Item = item;
            Dorg = dorg;
            Dtrc = dtrc;
            Qtnc = qtnc;
        }

        private static void Validate(string nuor, double qtnc, Item item)
        {
            DomainException.When(string.IsNullOrEmpty(nuor), "Order Number Invalid");
            DomainException.When(qtnc > 0, "Order Quantity Invalid");
            DomainException.When(item == null, "Invalid Item");
        }
    }
}
