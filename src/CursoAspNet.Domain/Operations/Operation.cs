using CursoAspNet.Domain.Orders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAspNet.Domain.Operations
{
    public class Operation : Entity
    {
        public Order Order { get; private set; }
        public string Nope { get; private set; }
        public int Nseq { get; private set; }
        public string Dope { get; private set; }        

        private Operation()
        {
        }
        public Operation (Order order, string nope, int nseq, string dope)
        {
            Validate(order, nope, nseq, dope);
            SetValues(order, nope, nseq, dope);
        }

        public void Update (Order order, string nope, int nseq, string dope)
        {
            Validate(order, nope, nseq, dope);
            SetValues(order, nope, nseq, dope);
        }

        private void SetValues(Order order, string nope, int nseq, string dope)
        {
            Order = order;
            Nope = nope;
            Nseq = nseq;
            Dope = dope;            
        }

        private static void Validate(Order order, string nope, int nseq, string dope)
        {
            DomainException.When(order == null, "Invalid Order");
            DomainException.When(string.IsNullOrEmpty(nope), "Invalid Operation Number");
            DomainException.When(nseq <= 0, "Invalid Sequence Number");
            DomainException.When(string.IsNullOrEmpty(dope), "Invalid Operation Description");
        }
    }
}
