//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct M512 : IAsmMemoryOp<M512,W512,FixedCell512>
    {
        public FixedCell512 Data;

        [MethodImpl(Inline)]
        public M512(FixedCell512 src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator M512(FixedCell512 src)
            => new M512(src);

        [MethodImpl(Inline)]
        public static implicit operator M512(Vector512<ulong> src)
            => new M512(src);

        [MethodImpl(Inline)]
        public static implicit operator FixedCell512(M512 src)
            => src.Data;

        FixedCell512 IAsmOperand<FixedCell512>.Content
            => Data;
    }
}