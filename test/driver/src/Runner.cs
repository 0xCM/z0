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
        readonly IWfShell Wf;

        public TestRunner(IWfShell wf)
        {
            Wf = wf;
        }

        public void Dispose()
        {

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