//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;
    using System.Reflection;

    struct App
    {
        public static void Main(params string[] args)
        {
            var wf = Apps.shell(Assembly.GetEntryAssembly(), args, out var app);
            var state = new WfCaptureState(wf, new AsmContext(app, wf));
            using var control = new CaptureControl(state);
            control.Run();
        }
    }

    public static partial class XTend { }
}