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

        public Type Type  => Host.Type;

        public StringRef Name => Host.Name;

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

    public readonly struct WfShellHost<H>
        where H : IWfHost<H>, new()

    {
        public IWfShell Wf {get;}

        public H Host {get;}

        public WfHost UntypedHost
            => new WfHost(Id, Type, Launcher);

        public WfStepId Id
            => Host.Id;

        public Type Type
            => Host.Type;

        public StringRef Name
            => Host.Name;

        public WfStepLaunchers.Launch Launcher
            => Host.Launcher;

        [MethodImpl(Inline)]
        public static implicit operator WfShellHost<H>((IWfShell wf, H host) src)
            => new WfShellHost<H>(src.wf,src.host);

        [MethodImpl(Inline)]
        public static implicit operator WfStepId(WfShellHost<H> src)
            => src.Id;

        [MethodImpl(Inline)]
        public static implicit operator WfHost(WfShellHost<H> src)
            => src.UntypedHost;

        [MethodImpl(Inline)]
        public static implicit operator WfShellHost(WfShellHost<H> src)
            => new WfShellHost(src.Wf, src.UntypedHost);

        [MethodImpl(Inline)]
        public WfShellHost(IWfShell wf, H host)
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