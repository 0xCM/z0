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

    public sealed class WfSelfHost : WfHost<WfSelfHost>
    {
        [MethodImpl(Inline)]
        public static WfSelfHost create(Type self)
            => new WfSelfHost(self);

        protected override void Execute(IWfShell shell)
        {

        }

        Type HostType;

        public override WfStepId Id
            => HostType;

        [MethodImpl(Inline)]
        public WfSelfHost()
            => HostType = typeof(WfSelfHost);

        [MethodImpl(Inline)]
        public WfSelfHost(Type host)
            => HostType = host;
    }
}