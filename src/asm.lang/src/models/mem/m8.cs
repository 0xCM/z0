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
        /// Defines an 8-bit memory operand
        /// </summary>
        public struct m8 : IMemOp8<m8>
        {
            [MethodImpl(Inline)]
            public static implicit operator mem<m8>(m8 src)
                => src;
        }
    }
}
