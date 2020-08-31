//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;

    public struct M256 : IAsmMemoryOp<M256,W256,FixedCell256>
    {
        public FixedCell256 Data;

        [MethodImpl(Inline)]
        public M256(FixedCell256 src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator M256(FixedCell256 src)
            => new M256(src);

        [MethodImpl(Inline)]
        public static implicit operator M256(Vector256<ulong> src)
            => new M256(src);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell256(M256 src)
            => src.Data;

        FixedCell256 IAsmOperand<FixedCell256>.Content
            => Data;
    }
}