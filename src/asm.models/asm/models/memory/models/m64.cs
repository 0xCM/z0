//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct M64 : IAsmMemOperand64<M64,ulong>
    {
        public ulong Data;

        [MethodImpl(Inline)]
        public static implicit operator M64(ulong src)
            => new M64(src);

        [MethodImpl(Inline)]
        public static implicit operator ulong(M64 src)
            => src.Data;

        [MethodImpl(Inline)]
        public M64(ulong src)
            => Data = src;

        public DataWidth Width
            => DataWidth.W64;

        ulong IAsmOperand<ulong>.Content
            => Data;
    }
}