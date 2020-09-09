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

    public struct M128 : IAsmMemoryOp<M128,W128,Cell128>
    {
        public Cell128 Data;

        [MethodImpl(Inline)]
        public M128(Cell128 src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator M128(Cell128 src)
            => new M128(src);

        [MethodImpl(Inline)]
        public static implicit operator M128(Vector128<ulong> src)
            => new M128(src);

        [MethodImpl(Inline)]
        public static implicit operator Cell128(M128 src)
            => src.Data;

        Cell128 IAsmOperand<Cell128>.Content
            => Data;
    }
}