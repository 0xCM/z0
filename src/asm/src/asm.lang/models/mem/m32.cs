//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmMem
    {
        /// <summary>
        /// Defines a 32-bit memory operand
        /// </summary>
        public struct m32 : IMemOp<m32,W32,uint>, IMemOp32<uint>
        {
            public uint Content {get;}

            [MethodImpl(Inline)]
            public m32(uint src)
                => Content = src;

            [MethodImpl(Inline)]
            public static implicit operator m32(uint src)
                => new m32(src);

            [MethodImpl(Inline)]
            public static implicit operator uint(m32 src)
                => src.Content;

            [MethodImpl(Inline)]
            public static implicit operator m32(Cell32 src)
                => new m32(src.Content);

        }
    }
}