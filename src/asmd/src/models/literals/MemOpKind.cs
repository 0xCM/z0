//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// Classifies memory operands
    /// </summary>
    public enum MemOpKind : byte
    {
        None = 0,

        /// <summary>
        /// Designates an 8-bit memory operand
        /// </summary>
        m8 = 0b0001,

        /// <summary>
        /// Designates an 16-bit memory operand
        /// </summary>
        m16 = 0b0010,

        /// <summary>
        /// Designates a 32-bit memory operand
        /// </summary>
        m32 = 0b0011,

        /// <summary>
        /// Designates an 64-bit memory operand
        /// </summary>
        m64 = 0b0100,

        /// <summary>
        /// Designates an 128-bit memory operand
        /// </summary>
        m128 = 0b0101,

        /// <summary>
        /// Designates an 256-bit memory operand
        /// </summary>
        m256 = 0b0100,

        /// <summary>
        /// Designates an 512-bit memory operand
        /// </summary>
        m512 = 0b0111,        
    }
}