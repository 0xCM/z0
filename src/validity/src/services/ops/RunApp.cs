//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class TestApp<A>
    {
        public static void Run(params string[] args)
        {
            var app = new A();
            app.InjectShell(WfShell.create(args));
            app.SetMode(InDiagnosticMode);
            app.RunTests();
        }

        public static void Run(PartId part, params string[] units)
        {
            var app = new A();
            var shell = WfShell.create(WfShell.parts(new PartId[1]{part}), sys.empty<string>());
            app.InjectShell(shell);
            app.SetMode(InDiagnosticMode);
            app.RunTests(units);
        }
    }
}