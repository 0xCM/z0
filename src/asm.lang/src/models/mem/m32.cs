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
        /// Defines a 32-bit memory operand
        /// </summary>
        public struct m32 : IMemOp32<m32>
        {

            [MethodImpl(Inline)]
            public static implicit operator mem<m32>(m32 src)
                => src;
        }
    }
}
