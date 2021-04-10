//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmOps
    {
        /// <summary>
        /// Defines a 16-bit memory operand
        /// </summary>
        public struct m16 : IMemOp16<m16>
        {
            [MethodImpl(Inline)]
            public static implicit operator mem<m16>(m16 src)
                => src;
        }

    }
}
