//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    ref struct Runner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public Runner(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(Runner));
            Wf = wf.WithHost(Host);
        }

        public void Dispose()
        {
        }

        void CloneTables()
        {
            var models = TableModels.create();
            var count = models.Count;
            var view = models.View;
            for(var i =0; i<count; i++)
            {
                ref readonly var model = ref skip(view,i);
                var clone = CilTableSpecs.clone(model);
                Wf.Rows(clone);

            }

        }

        public void Run()
        {
            var o1 = Cmd.option("option1_name", "option1_value");
            var o2 = Cmd.option("option2_name", "option2_value");
            var o3 = Cmd.option("option3_name", "option3_value");
            var options = Cmd.options(o1,o2,o3);
            Wf.Status(options);
        }
    }
}