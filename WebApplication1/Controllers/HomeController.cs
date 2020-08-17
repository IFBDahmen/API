using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;
using Solution3.Module.BusinessObjects.Beispiel;
using System.Reactive.Linq;
//using Xpand.XAF.Modules.SequenceGenerator;
//using System.Reactive.Linq;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            
            //System.Data.SqlClient.SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();

           

            //string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            // IDataLayer ImportDataLayer = DevExpress.Xpo.XpoDefault.GetDataLayer(, AutoCreateOption.None );

            string str = "XpoProvider=MSSqlServer;data source=IF-PC24;integrated security=SSPI;initial catalog=Beispiel";
            UnitOfWork unitOfWork = new UnitOfWork(XpoDefault.GetDataLayer(str, DevExpress.Xpo.DB.AutoCreateOption.None));
            Xpand.XAF.Modules.SequenceGenerator.SequenceGeneratorService.Sequence.OfType<Student>() 
            .Subscribe();

            Session session = new Session(unitOfWork.ObjectLayer);
            Student student = new Student(session);
            
            student.Name = "Newi1308";
            
            
            unitOfWork.CommitChanges();
            List<Student> students1 = new List<Student>();
            students1.Add(student);
            List<Student> students2 = new List<Student>();
            unitOfWork.ObjectLayer.CommitChanges(session,students2,students1);
            IList<Student> students = unitOfWork.Query<Student>().ToList();
            student.Delete();
            unitOfWork.CommitTransaction();
            return View();
        }
    }
}
