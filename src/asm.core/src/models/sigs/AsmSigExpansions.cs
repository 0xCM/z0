//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmSigExpansions
    {
        [SymSource]
        public enum GpRmExpansion : byte
        {
            [Symbol("/r", "Indicates that the ModR/M byte of the instruction contains a register operand and an r/m operand")]
            r,

            [Symbol("r8", "Represents an 8-bit gp register")]
            r8,

            [Symbol("m8", "Represents an 8-bit memory operand")]
            m8,

            [Symbol("r16", "Represents a 16-bit gp register")]
            r16,

            [Symbol("m16", "Represents a 16-bit memory operand")]
            m16,

            [Symbol("r32", "Represents a 32-bit gp register")]
            r32,

            [Symbol("m32", "Represents a 32-bit memory operand")]
            m32,

            [Symbol("r64", "Represents a 64-bit gp register")]
            r64,

            [Symbol("m64", "Represents a 64-bit memory operand")]
            m64,
        }


        [SymSource]
        public enum ZmmBCastExpansion : byte
        {
            /// <summary>
            /// Represents a zmm vector
            /// </summary>
            [Symbol("zmm", "Represents a zmm vector")]
            Zmm,

            /// <summary>
            /// Represents a 512-bit memory location
            /// </summary>
            [Symbol("m512", "Represents a 512-bit memory location")]
            M512,

            /// <summary>
            /// Represents a zmm vector loaded from a 32-bit memory location
            /// </summary>
            [Symbol("m32bcst", "Represents a zmm vector loaded from a 32-bit memory location")]
            Zmm512x32,

            /// <summary>
            /// Represents a zmm vector loaded from a 64-bit memory location
            /// </summary>
            [Symbol("m64bcst", "Represents a zmm vector loaded from a 64-bit memory location")]
            Zmm512x64,
        }
    }
}