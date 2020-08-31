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
                Context.AppPaths.TestErrorPath.Delete();
                Context.AppPaths.TestStatusPath.Delete();

                RunTests(false,filters);

                EmitLogs();
            }
            catch (Exception e)
            {
                Flush(e, TestLog.Create());
            }
        }
    }
}