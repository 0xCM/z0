//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial class TestApp<A>
    {
        public static void Run(params string[] args)
        {
            var app = new A();
            app.InjectShell(WfShell.create(ApiCatalogs.parts(root.controller(), args), args));
            app.SetMode(InDiagnosticMode);
            app.RunTests();
        }

        public static void Run(PartId part, params string[] units)
        {
            Run(root.array(part), units);
        }

        public static void Run(Index<PartId> parts, params string[] units)
        {
            var app = new A();
            var shell = WfShell.create(ApiCatalogs.parts(parts), sys.empty<string>());
            app.InjectShell(shell);
            app.SetMode(InDiagnosticMode);
            app.RunTests(units);
        }

        public static void Run(Index<PartId> parts, Action<IWfShell> runner)
        {
            using var shell = WfShell.create(ApiCatalogs.parts(parts), sys.empty<string>());
            runner(shell);
        }
    }
}