//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public sealed class WfSelfHost : WfHost<WfSelfHost>
    {
        protected override void Execute(IWfRuntime shell)
            => AppErrors.missing();

        Type HostType;

        Name HostName;

        public override WfStepId Id
            => HostName;

        [MethodImpl(Inline)]
        public WfSelfHost()
        {
            HostType = typeof(WfSelfHost);
            HostName = "<no-proxy-specified>";
        }

        [MethodImpl(Inline)]
        public WfSelfHost(Type host)
        {
            HostType = host;
            HostName = host.Name;
        }

        [MethodImpl(Inline)]
        public WfSelfHost(Name name)
        {
            HostType = typeof(WfSelfHost);
            HostName = name;
        }
    }
}