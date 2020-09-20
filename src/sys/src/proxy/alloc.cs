//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static OpacityApiKey;

    partial struct proxy
    {
        [MethodImpl(Options), Opaque(Alloc), Closures(Closure)]
        public static T[] alloc<T>(int count)
            => new T[count];

        [MethodImpl(Options),  Opaque(Alloc)]
        public static byte[] alloc(int count)
            => new byte[count];
    }
}