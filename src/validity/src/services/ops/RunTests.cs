//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    partial class TestApp<A>
    {
        void RunTests(bool concurrent, params string[] filters)
        {

            var hosts = SelectedHosts.IsNonEmpty ? SelectedHosts.Storage : FindHosts();
            root.iter(hosts, h =>  RunUnit(h,filters), concurrent);
        }

        protected virtual void RunTests(params string[] filters)
        {
            try
            {
                var flow = Wf.Running(typeof(A).Name + " tests");
                ErroLogPath.Delete();
                StatusLogPath.Delete();
                RunTests(false, filters);
                EmitLogs();
                Wf.Ran(flow);
            }
            catch (Exception e)
            {
                term.error(e);
            }
        }
    }
}