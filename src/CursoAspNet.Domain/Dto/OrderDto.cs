using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAspNet.Domain.Dto
{
    public class OrderDto
    {
        public int Id { get; private set; }
        public int ItemId { get; set; }
        public string Nuor { get; private set; }
        public DateTime Dorg { get; private set; }
        public DateTime Dtrc { get; private set; }
        public Double Qtnc { get; private set; }        
    }
}
