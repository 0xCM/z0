//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct ApiSurfaceRoot
    {
        readonly Type RootType;

        [MethodImpl(Inline)]
        public ApiSurfaceRoot(Type src)
            => RootType = src;

        [MethodImpl(Inline)]
        public static implicit operator ApiSurfaceRoot(Type src)
            => new ApiSurfaceRoot(src);
    }
}