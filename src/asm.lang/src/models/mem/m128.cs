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
        public struct m128 : IMemOp128<m128>
        {

        }
    }
}
