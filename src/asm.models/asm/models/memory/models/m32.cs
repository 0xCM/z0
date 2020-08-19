//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct M32 : IAsmMemOperand32<M32,uint>
    {
        public uint Data;

        [MethodImpl(Inline)]
        public static implicit operator M32(uint src)
            => new M32(src);

        [MethodImpl(Inline)]
        public static implicit operator uint(M32 src)
            => src.Data;

        [MethodImpl(Inline)]
        public M32(uint src)
            => Data = src;

        uint IAsmOperand<uint>.Content
            => Data;
    }
}