//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Reflection;

    ref struct TestRunner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public TestRunner(IWfShell wf)
        {
            Host = WfShell.host(typeof(TestRunner));
            Wf = wf.WithHost(Host);
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            using var flow = Wf.Running();
            //MathTestApp.run();
            //BitsTestApp.run();
            // AsmTestApp.run();
            // LogixTestApp.run();
            // SymbolicTestApp.run();
            // GVecTestApp.run();

        }
    }
}