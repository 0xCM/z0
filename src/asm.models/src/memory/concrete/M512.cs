//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public struct M512 : IAsmMemoryArg<M512,W512,Cell512>
    {
        public Cell512 Data;

        [MethodImpl(Inline)]
        public M512(Cell512 src)
            => Data = src;

        [MethodImpl(Inline)]
        public static implicit operator M512(Cell512 src)
            => new M512(src);

        [MethodImpl(Inline)]
        public static implicit operator M512(Vector512<ulong> src)
            => new M512(src);

        [MethodImpl(Inline)]
        public static implicit operator Cell512(M512 src)
            => src.Data;

        Cell512 IAsmArg<Cell512>.Content
            => Data;
    }
}