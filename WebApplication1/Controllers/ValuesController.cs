using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Xpo;
using Solution3.Module.BusinessObjects.Beispiel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Xpand.XAF.Modules.SequenceGenerator;

namespace WebApplication1.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
           
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public long Post([FromBody] string value)
        {
            string str = "XpoProvider=MSSqlServer;data source=IF-PC24;integrated security=SSPI;initial catalog=Beispiel";
            UnitOfWork unitOfWork = new UnitOfWork(XpoDefault.GetDataLayer(str, DevExpress.Xpo.DB.AutoCreateOption.None));
            
            Session session = new Session(unitOfWork.ObjectLayer);
            Student student = new Student(session);

            student.Name = value;
            student.Save();

            unitOfWork.CommitChanges();

            return student.ID;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
