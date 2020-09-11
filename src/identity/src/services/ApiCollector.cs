//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public readonly struct ApiCollector : IApiCollector
    {
        public static ApiCollector Service
            => default;

        public IEnumerable<DirectApiGroup> ImmDirect(ApiHost host, ImmRefinementKind kind)
            => ApiImmediates.direct(host,kind);

        public IEnumerable<GenericApiMethod> ImmGeneric(ApiHost host, ImmRefinementKind kind)
            => ApiImmediates.generic(host,kind);
    }
}