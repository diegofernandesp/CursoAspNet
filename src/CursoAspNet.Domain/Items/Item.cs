using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAspNet.Domain.Items
{
    public class Item : Entity
    {
        public string Citm { get; private set; }
        public string Ditm { get; private set; }
        public double Qtdp { get; private set; }
        public string Poor { get; private set; }

        private Item()
        {
        }
        public Item (string citm, string ditm, double qtdp, string poor)
        {
            Validate(citm, ditm, qtdp, poor);
            SetValues(citm, ditm, qtdp, poor);
        }

        public void Update (string citm, string ditm, double qtdp, string poor)
        {
            Validate(citm, ditm, qtdp, poor);
            SetValues(citm, ditm, qtdp, poor);
        }

        private void SetValues(string citm, string ditm, double qtdp, string poor)
        {
            Citm = citm;
            Ditm = ditm;
            Qtdp = qtdp;
            Poor = poor;
        }

        private static void Validate(string citm, string ditm, double qtdp, string poor)
        {
            DomainException.When(string.IsNullOrEmpty(citm), "Invalid Item Code");
            DomainException.When(string.IsNullOrEmpty(ditm), "Invalid Item Description");
            DomainException.When(qtdp < 0, "Invalid Item Stock Quantity");
            DomainException.When(string.IsNullOrEmpty(poor), "Invalid Order Policy");
        }
    }
}
