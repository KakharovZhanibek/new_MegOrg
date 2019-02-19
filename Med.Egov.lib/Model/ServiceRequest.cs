using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace Med.Egov.lib.Model
{
    public class ServiceRequest
    {
        private LiteEntity db = new LiteEntity();
        Logger logger = LogManager.GetCurrentClassLogger();
        public bool createRequest(Request r)
        {
            try
            {
                db.createRequest(r);
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex.Message);
                return false;
            }
        }
    }
}
