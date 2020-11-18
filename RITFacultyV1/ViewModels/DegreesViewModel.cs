using System;
using System.Collections.Generic;
using RITFacultyV1.Models;

namespace RITFacultyV1.ViewModels
{
    public class DegreesViewModel
    {
        public List<Undergraduate> undergrad { get; set; }
        public List<Graduate> graduate { get; set; }
        public string Title { get; set; }
    }
}
