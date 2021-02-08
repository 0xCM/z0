//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;

    partial struct AsmMem
    {
        /// <summary>
        /// Defines a 128-bit memory operand
        /// </summary>
        public struct m128 : IMemOp<m128,W128,Cell128>
        {
            public Cell128 Content {get;}

            [MethodImpl(Inline)]
            public m128(Cell128 src)
                => Content = src;

            [MethodImpl(Inline)]
            public static implicit operator m128(Cell128 src)
                => new m128(src);

            [MethodImpl(Inline)]
            public static implicit operator m128(Vector128<ulong> src)
                => new m128(src);

            [MethodImpl(Inline)]
            public static implicit operator Cell128(m128 src)
                => src.Content;
        }
    }
}