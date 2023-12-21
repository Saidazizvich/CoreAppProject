using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concreate
{
	public class Regard
	{
        [Key]
        public int RegardId { get; set; }

        public string RegardDetails1 { get; set; }

        public string RegardDetails2 { get; set; }

        public string RegardImage1 { get; set; }

        public string RegardImage2 { get; set; }

        public string RegardMapLocation { get; set; }

        public string RegardStatus { get; set; }
    }
}
