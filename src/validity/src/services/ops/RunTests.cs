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
        void RunTests(bool concurrent, Index<string> hosts)
        {
            var types = hosts.IsEmpty ? FindHosts() : FindHosts(hosts);
            root.iter(types, h =>  RunUnit(h), concurrent);
        }

        protected virtual void RunTests(params string[] hosts)
        {
            try
            {
                var flow = Wf.Running(typeof(A).Name + " tests");
                ErroLogPath.Delete();
                StatusLogPath.Delete();
                RunTests(false, hosts);
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