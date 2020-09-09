//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using Z0.Asm;

    using static z;

    struct App
    {
        public static void Main(params string[] args)
        {
            var wf = Apps.shell(Assembly.GetEntryAssembly(), args, out var app);
            var state = new WfCaptureState(wf, new AsmContext(app, wf), wf.Config, wf.Ct);
            using var machine = new Engine(state, wf.Ct);
            machine.Run();
        }
    }

    public static partial class XTend {}
}