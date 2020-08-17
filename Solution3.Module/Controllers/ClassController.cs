using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using Solution3.Module.BusinessObjects.Beispiel;

namespace Solution3.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class ClassController : ViewController
    {
        public ClassController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void simpleAction1_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
            //IObjectSpace objectspace = Application.CreateObjectSpace();
            
            //Session currentSession = ((XPObjectSpace)objectspace).Session;
            //GroupA groupA = new GroupA(currentSession);
            //groupA.Name = "A"+ DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
            //groupA.Save();
            ////View.ObjectSpace.CommitChanges();
            
            //GroupB groupB = new GroupB(currentSession);
            //groupB.Name = "B" + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
            //groupB.Save();
            ////View.ObjectSpace.CommitChanges();

            //Class cl = new Class(((XPObjectSpace)View.ObjectSpace).Session);
            //cl.Name = "Class" + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
            //cl.Save();
            //View.ObjectSpace.CommitChanges();
            //objectspace.CommitChanges();
            Dog dog = new Dog(((XPObjectSpace)View.ObjectSpace).Session);
            dog.Name = "wuffie";
            dog.Save();
            View.ObjectSpace.CommitChanges();
        }
    }
}
