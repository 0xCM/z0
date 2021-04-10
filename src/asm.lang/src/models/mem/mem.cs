//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static AsmX;

    partial struct AsmOps
    {
        /// <summary>
        /// Defines a 128-bit memory operand
        /// </summary>
        public struct mem<T> : IMemOp<mem<T>>
            where T : unmanaged
        {


        }
    }
}
