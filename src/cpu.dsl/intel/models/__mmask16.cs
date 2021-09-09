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
        public struct __mmask16
        {
            ushort Data;

            [MethodImpl(Inline)]
            public __mmask16(ushort src)
                => Data = src;

            [MethodImpl(Inline)]
            public static implicit operator __mmask16(ushort src)
                => new __mmask16(src);

            [MethodImpl(Inline)]
            public static implicit operator ushort(__mmask16 src)
                => src.Data;
        }
    }
}