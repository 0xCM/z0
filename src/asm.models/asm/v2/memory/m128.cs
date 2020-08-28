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

    public struct M128 : IAsmMemoryOp<M128,W128,Fixed128>
    {
        public Fixed128 Data;

        [MethodImpl(Inline)]
        public M128(Fixed128 src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator M128(Fixed128 src)
            => new M128(src);

        [MethodImpl(Inline)]
        public static implicit operator M128(Vector128<ulong> src)
            => new M128(src);

        [MethodImpl(Inline)]
        public static implicit operator Fixed128(M128 src)
            => src.Data;

        Fixed128 IAsmOperand<Fixed128>.Content
            => Data;
    }
}