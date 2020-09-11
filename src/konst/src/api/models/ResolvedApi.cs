//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Konst;

    public readonly struct ResolvedApi : IResolvedApi
    {
        public IPart[] Resolved {get;}

        public Assembly[] Components {get;}

        [MethodImpl(Inline)]
        public static implicit operator ResolvedApi(ApiSet src)
            => new ResolvedApi(src);

        [MethodImpl(Inline)]
        public ResolvedApi(ApiSet parts)
        {
            Resolved = parts.Parts;
            Components = parts.Components;
        }
    }

}