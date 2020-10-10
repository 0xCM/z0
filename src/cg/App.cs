//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static z;
    using static Konst;

    readonly struct App
    {
        public static int Main(params string[] args)
        {
            using var wf = WfShell.shell(args);
            AppWf.create().Run(wf);
            return 0;
        }
    }

    public sealed class AppWf : WfHost<AppWf>
    {
        protected override void Execute(IWfShell wf)
        {
            using var step = new AppWfStep(wf,this);
            step.Run();
        }
    }

    ref struct AppWfStep
    {
        readonly IWfShell Wf;

        readonly WfHost Host;

        [MethodImpl(Inline)]
        public AppWfStep(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
            Wf.Created(Host);
        }

        public void Dispose()
        {
            Wf.Disposed(Host);
        }

        public void Run()
        {
            Wf.Running(Host);


            Wf.Ran(Host);
        }
    }
}