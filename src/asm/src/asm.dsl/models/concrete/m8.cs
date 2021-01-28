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
        /// Defines an 8-bit memory operand
        /// </summary>
        public struct m8 : IMemOp<m8,W8,byte>
        {
            public byte Content {get;}

            [MethodImpl(Inline)]
            public m8(byte src)
                => Content = src;

            [MethodImpl(Inline)]
            public static implicit operator m8(byte src)
                => new m8(src);

            [MethodImpl(Inline)]
            public static implicit operator byte(m8 src)
                => src.Content;
        }
    }
}