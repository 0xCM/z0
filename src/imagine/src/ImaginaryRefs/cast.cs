//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct Imagine
    {
        [MethodImpl(Inline)]
        public static ref T cast<S,T>(in S src)
            => ref Unsafe.As<S,T>(ref edit(src));
    }
}