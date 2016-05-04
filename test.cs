using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PppLearning.Sis.UI.Models
{
    public class SisMapping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DistrictId { get; set; }
        public string SisSchoolId { get;set;}
        public string Country { get; set; }
        public string MapStatus { get; set; }
        public int SisClientId { get; set; }
        public int SchoolMappingId { get; set; }
        public int CrmId { get; set; }
        public string DistrictName { get; set; }

    }
}