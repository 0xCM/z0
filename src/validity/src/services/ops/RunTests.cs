//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    partial class TestApp<A>
    {
        void RunTests(bool concurrent, params string[] filters)
        {
            var hosts = FindHosts();
            iter(hosts, h =>  RunUnit(h,filters), concurrent);
        }

        protected virtual void RunTests(params string[] filters)
        {
            try
            {
                Context.TestPaths.ErrorLogPath.Delete();
                Context.TestPaths.StatusLogPath.Delete();

                RunTests(false,filters);

                EmitLogs();
            }
            catch (Exception e)
            {
                term.error(e);
            }
        }
    }
}