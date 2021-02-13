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
        /// Defines a 16-bit memory operand
        /// </summary>
        public struct m16 : IMemOp<m16,W16,ushort>, IMemOp16<ushort>
        {
            public ushort Content {get;}

            [MethodImpl(Inline)]
            public m16(ushort src)
                => Content = src;

            [MethodImpl(Inline)]
            public static implicit operator m16(ushort src)
                => new m16(src);

            [MethodImpl(Inline)]
            public static implicit operator ushort(m16 src)
                => src.Content;
        }
    }
}