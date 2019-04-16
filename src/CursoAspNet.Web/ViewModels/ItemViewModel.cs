using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CursoAspNet.Web.ViewModels
{
    public class ItemViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Citm { get; set; }

        [Required]
        public string Ditm { get; set; }

        [Required]
        public double Qtdp { get; set; }

        [Required]
        public string Poor { get; set; }
    }
}
