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

    using static Konst;
    using static z;

    ref struct TestRunner
    {
        readonly WfHost Host;

        readonly IWfShell Wf;

        public TestRunner(IWfShell wf)
        {
            Host = WfSelfHost.create(typeof(TestRunner));
            Wf = wf.WithHost(Host);
        }

        public void Dispose()
        {
            Wf.Disposed();
        }

        public void Run()
        {
            using var flow = Wf.Running();
            BitsTestApp.run();
            // MathTestApp.run();
            // AsmTestApp.run();
            // LogixTestApp.run();
            // SymbolicTestApp.run();
            // GVecTestApp.run();

        }
    }
}