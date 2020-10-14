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

        public void Run()
        {
            var models = TableModels.create();
            var count = models.Count;
            var view = models.View;
            for(var i =0; i<count; i++)
            {
                ref readonly var model = ref skip(view,i);
                var clone = TableBuilder.clone(model);
                Wf.Rows(clone);

            }
        }
    }
}