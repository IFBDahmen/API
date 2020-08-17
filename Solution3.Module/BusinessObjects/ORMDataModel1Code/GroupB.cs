using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace Solution3.Module.BusinessObjects.Beispiel
{

    public partial class GroupB
    {
        public GroupB(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
