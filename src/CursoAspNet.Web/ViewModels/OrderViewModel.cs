using System;
using System.Collections.Generic;
using System.Text;

namespace CursoAspNet.Web.ViewModels
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Nuor { get; set; }
        public DateTime Dorg { get; set; }
        public DateTime Dtrc { get; set; }
        public Double Qtnc { get; set; }        
    }
}
