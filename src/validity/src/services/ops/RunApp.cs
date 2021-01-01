//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class TestApp<A>
    {
        public static void Run(params string[] args)
        {
            var app = new A();
            app.InjectShell(WfShell.create(args));
            app.SetMode(InDiagnosticMode);
            app.RunTests();
        }
    }
}