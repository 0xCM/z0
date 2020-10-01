//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct M16 : IAsmMemOp<M16,W16,ushort>
    {
        public ushort Data;

        [MethodImpl(Inline)]
        public static implicit operator M16(ushort src)
            => new M16(src);

        [MethodImpl(Inline)]
        public static implicit operator ushort(M16 src)
            => src.Data;

        [MethodImpl(Inline)]
        public M16(ushort src)
            => Data = src;

        ushort IAsmOperand<ushort>.Content
            => Data;
    }
}