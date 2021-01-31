//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmDsl
    {
        /// <summary>
        /// Defines a 512-bit memory operand
        /// </summary>
        public struct m512 : IMemOp<m512,W512,Cell512>
        {
            public Cell512 Content {get;}

            [MethodImpl(Inline)]
            public m512(Cell512 src)
                => Content = src;

            [MethodImpl(Inline)]
            public static implicit operator m512(Cell512 src)
                => new m512(src);

            [MethodImpl(Inline)]
            public static implicit operator m512(Vector512<ulong> src)
                => new m512(src);

            [MethodImpl(Inline)]
            public static implicit operator Cell512(m512 src)
                => src.Content;
        }
    }
}