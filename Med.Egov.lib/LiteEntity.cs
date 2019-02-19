using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;
using Med.Egov.lib.Model;

namespace Med.Egov.lib
{
    public class LiteEntity
    {
        private LiteDatabase db = null;
        public LiteEntity()
        {
            db = new LiteDatabase("Med.db");
        }
        public void createRequest(Request r)
        {
            var requests = db.GetCollection<Request>("requests");
            requests.Insert(r);
        }
        public List<Request> getRequests()
        {
            var requests = db.GetCollection<Request>("requests");
            return requests.FindAll().ToList();
        }
        public List<Request> getRequests(int id)
        {
            var requests = db.GetCollection<Request>("requests");
            return requests.FindAll().Where(w => w.id == id).ToList();
        }

        public List<Request> getRequestsByPatientId(int id)
        {
            var requests = db.GetCollection<Request>("requests");
            return requests.FindAll().Where(w => w.patient_id == id).ToList();
        }

        public List<Request> getRequestsByMedOrgId(int id)
        {
            var requests = db.GetCollection<Request>("requests");
            return requests.FindAll().Where(w => w.medOrg_id == id).ToList();
        }
        public void updateRequest(Request r)
        {
            var requests = db.GetCollection<Request>("requests");
            requests.Update(r);
        }
    }
}
