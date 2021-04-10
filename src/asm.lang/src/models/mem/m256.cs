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
        public struct m256 : IMemOp256<m256>
        {

            [MethodImpl(Inline)]
            public static implicit operator mem<m256>(m256 src)
                => src;
        }
    }
}
