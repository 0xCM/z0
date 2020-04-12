//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static Vec128Kind<T> VectorKind<T>(this W128 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vec256Kind<T> VectorKind<T>(this W256 w)
            where T : unmanaged
                => default;

        [MethodImpl(Inline)]
        public static Vec512Kind<T> VectorKind<T>(this W512 w)
            where T : unmanaged
                => default;

    }
}