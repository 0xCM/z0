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
            app.InjectShell(WfRuntime.create(ApiRuntimeLoader.parts(core.controller(), args), args));
            app.SetMode(InDiagnosticMode);
            app.RunTests();
        }

        public static void Run(PartId part, params string[] units)
        {
            Run(core.array(part), units);
        }

        public static void Run(Index<PartId> parts, params string[] units)
        {
            var app = new A();
            var shell = WfRuntime.create(ApiRuntimeLoader.parts(parts), sys.empty<string>());
            app.InjectShell(shell);
            app.SetMode(InDiagnosticMode);
            app.RunTests(units);
        }

        public static void Run(Index<PartId> parts, Action<IWfRuntime> runner)
        {
            using var shell = WfRuntime.create(ApiRuntimeLoader.parts(parts), sys.empty<string>());
            runner(shell);
        }
    }
}