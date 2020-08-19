//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct M8 : IAsmMemOperand8<M8,byte>
    {
        public byte Data;

        [MethodImpl(Inline)]
        public static implicit operator M8(byte src)
            => new M8(src);

        [MethodImpl(Inline)]
        public static implicit operator byte(M8 src)
            => src.Data;

        [MethodImpl(Inline)]
        public M8(byte src)
            => Data = src;

        byte IAsmOperand<byte>.Content
            => Data;
    }
}