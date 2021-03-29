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
        /// Defines a 256-bit memory operand
        /// </summary>
        public struct m256 : IMemOp<m256,W256,Cell256>, IMemOp256<Cell256>
        {
            public Cell256 Content {get;}

            [MethodImpl(Inline)]
            public m256(Cell256 src)
                => Content = src;

            [MethodImpl(Inline)]
            public static implicit operator m256(Cell256 src)
                => new m256(src);

            [MethodImpl(Inline)]
            public static implicit operator m256(Vector256<ulong> src)
                => new m256(src);

            [MethodImpl(Inline)]
            public static implicit operator Cell256(m256 src)
                => src.Content;
        }
    }
}