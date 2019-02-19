using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med.Egov.lib.Model
{
    public enum RequestStatus { create, approve, reject }
    public class Request
    {
        public int id { get; set; }
        public DateTime createDate { get; set; } = DateTime.Now;
        public DateTime processDate { get; set; }
        public int patient_id { get; set; }

        public Patient patient = null;

        public int medOrg_id { get; set; }
        public MedOrg medOrg = null;
        public RequestStatus requestStatus { get; set; }

        public Request()
        {
            medOrg = new MedOrg();
            patient = new Patient();
        }
    }
}
