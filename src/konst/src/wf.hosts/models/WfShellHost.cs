//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public readonly struct WfShellHost : IWfHost<WfShellHost>
    {
        public IWfShell Wf {get;}

        public WfHost Host {get;}
        public WfStepId Id => Host.Id;

        public Type Type => Host.Type;

        public StringRef Name => Host.Name;

        public static implicit operator WfStepId(WfShellHost src)
            => src.Id;

        [MethodImpl(Inline)]
        public static implicit operator WfShellHost((IWfShell wf, WfHost host) src)
            => new WfShellHost(src.wf,src.host);

        [MethodImpl(Inline)]
        public WfShellHost(IWfShell wf, WfHost host)
        {
            Wf = wf;
            Host = host;
        }

        [MethodImpl(Inline)]
        public void Run(IWfShell shell)
            => Host.Run(shell);

        [MethodImpl(Inline)]
        public void Run()
            => Host.Run(Wf);
    }
}