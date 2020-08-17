using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Windows.Forms;

namespace Solution3.Module.BusinessObjects.Beispiel
{

    public partial class owner
    {
        public owner(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }

        protected override void OnSaving()
        {

            if (Dog is null)
            {
                Dog dog = new Dog(Session);
                dog.Name = "bello1";
                Save();
                Dog = dog;
            }

            base.OnSaving();

            //DevExpress.ExpressApp.Xpo.XPObjectSpace.FindObjectSpaceByObject(this).CommitChanges();
            //Session.CommitTransaction();
        }


    }

}
