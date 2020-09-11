//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct M32 : IAsmMemoryArg<M32,W32,uint>
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

        uint IAsmArg<uint>.Content
            => Data;
    }
}