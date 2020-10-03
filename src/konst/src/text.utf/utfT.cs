//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static z;

    public readonly struct Utf<T>
        where T : unmanaged
    {
        readonly T[] Data;

        [MethodImpl(Inline)]
        public Utf(T[] src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator Utf<T>(T[] src)
            => new Utf<T>(src);
    }
}