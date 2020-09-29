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

    public struct M256 : IMemoryArg<M256,W256,Cell256>
    {
        public Cell256 Data;

        [MethodImpl(Inline)]
        public M256(Cell256 src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator M256(Cell256 src)
            => new M256(src);

        [MethodImpl(Inline)]
        public static implicit operator M256(Vector256<ulong> src)
            => new M256(src);

        [MethodImpl(Inline)]
        public static implicit operator Cell256(M256 src)
            => src.Data;

        Cell256 IAsmArg<Cell256>.Content
            => Data;
    }
}