//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;


    [ApiHost]
    public readonly struct AsmMemOps
    {
        /// <summary>
        /// Defines an 8-bit memory operand
        /// </summary>
        public struct m8 : IMemOp8<m8>
        {


        }

        /// <summary>
        /// Defines a 16-bit memory operand
        /// </summary>
        public struct m16 : IMemOp16<m16>
        {


        }

        /// <summary>
        /// Defines a 32-bit memory operand
        /// </summary>
        public struct m32 : IMemOp32<m32>
        {


        }

        /// <summary>
        /// Defines a 64-bit memory operand
        /// </summary>
        public struct m64 : IMemOp32<m64>
        {

        }
    }
}