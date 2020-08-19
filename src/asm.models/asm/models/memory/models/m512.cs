//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct M512 : IAsmMemOperand512<M512,Fixed512>
    {
        public Fixed512 Data;

        [MethodImpl(Inline)]
        public M512(Fixed512 src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator M512(Fixed512 src)
            => new M512(src);

        [MethodImpl(Inline)]
        public static implicit operator M512(Vector512<ulong> src)
            => new M512(src);

        [MethodImpl(Inline)]
        public static implicit operator Fixed512(M512 src)
            => src.Data;

        Fixed512 IAsmOperand<Fixed512>.Content
            => Data;
    }
}