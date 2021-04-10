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
        /// Defines a 128-bit memory operand
        /// </summary>
        public struct m512 : IMemOp512<m512>
        {
            [MethodImpl(Inline)]
            public static implicit operator mem<m512>(m512 src)
                => src;
        }
    }
}
