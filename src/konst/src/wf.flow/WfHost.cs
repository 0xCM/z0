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

    public delegate void WfStepLauncher(IWfShell wf);

    public delegate void WfStepLauncher<H>(IWfShell wf, H host)
        where H : IWfHost<H>,new();

    public readonly struct WfHost : IWfHost<WfHost>
    {
        public WfStepId Id {get;}

        public Type Type {get;}

        public StringRef Name {get;}

        readonly WfStepLauncher Launch;

        [MethodImpl(Inline)]
        public static implicit operator WfStepId(WfHost src)
            => src.Id;

        [MethodImpl(Inline)]
        public WfHost(WfStepId id, Type type, WfStepLauncher launch)
        {
            Id =id;
            Type = type;
            Name = type.Name;
            Launch = launch;
        }

        public void Run(IWfShell shell)
        {
            Launch(shell);
        }
    }
}