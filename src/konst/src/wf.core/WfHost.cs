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

    using L = WfStepLaunchers;

    public readonly struct WfHost : IWfHost<WfHost>
    {
        public WfStepId Id {get;}

        public Type Type {get;}

        public StringRef Name {get;}

        public L.Launch Launcher {get;}

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => Type.Name;
        }

        [MethodImpl(Inline)]
        public static implicit operator WfStepId(WfHost src)
            => src.Id;

        [MethodImpl(Inline)]
        public WfHost(WfStepId id, Type type, L.Launch launch)
        {
            Id =id;
            Type = type;
            Name = type.Name;
            Launcher = launch;
        }

        [MethodImpl(Inline)]
        public void Run(IWfShell shell)
            => Launcher(shell);
    }
}