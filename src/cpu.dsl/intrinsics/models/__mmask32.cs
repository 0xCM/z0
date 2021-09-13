//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Vdsl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Intrinsics
    {
        public struct __mmask32
        {
            ushort Data;

            [MethodImpl(Inline)]
            public __mmask32(ushort src)
                => Data = src;

            [MethodImpl(Inline)]
            public static implicit operator __mmask32(ushort src)
                => new __mmask32(src);

            [MethodImpl(Inline)]
            public static implicit operator ushort(__mmask32 src)
                => src.Data;
        }
    }
}