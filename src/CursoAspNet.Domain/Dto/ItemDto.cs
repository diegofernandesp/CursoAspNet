using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAspNet.Domain.Dto
{
    public class ItemDto
    {
        public int Id { get; private set; }
        public string Citm { get; private set; }
        public string Ditm { get; private set; }
        public double Qtdp { get; private set; }
        public string Poor { get; private set; }
    }
}
