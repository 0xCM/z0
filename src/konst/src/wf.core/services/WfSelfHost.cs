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
        Type HostType;

        public override WfStepId Id => HostType;

        public static WfSelfHost create(Type self)
        {
            var host = new WfSelfHost();
            host.HostType = self;
            return host;
        }
    }
}