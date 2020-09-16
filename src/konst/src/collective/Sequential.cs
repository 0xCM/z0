//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Sequential
    {
        [MethodImpl(Inline)]
        public static Pairings<I,T> terms<H,I,T>(H src)
            where I : unmanaged
            where H : ISequentialHost<H,I,T>
                => src.Terms;

    }
}