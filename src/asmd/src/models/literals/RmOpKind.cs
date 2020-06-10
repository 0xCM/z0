//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    using M = MemOpKind;

    /// <summary>
    /// Classifies register/memory operands
    /// </summary>
    public enum RmOpKind : byte
    {
        None,
            
        /// <summary>
        /// Designates an 8-bit register or memory operand
        /// </summary>
        rm8 = M.m8,

        /// <summary>
        /// Designates a 16-bit register or memory operand
        /// </summary>
        rm16 = M.m16,

        /// <summary>
        /// Designates a 32-bit register or memory operand
        /// </summary>
        rm32 = M.m32,

        /// <summary>
        /// Designates a 64-bit register or memory operand
        /// </summary>
        rm64 = M.m64,

        /// <summary>
        /// Designates a 128-bit register or memory operand
        /// </summary>
        rxmm = M.m128,

        /// <summary>
        /// Designates a 256-bit register or memory operand
        /// </summary>
        rymm = M.m256,

        /// <summary>
        /// Designates a 512-bit register or memory operand
        /// </summary>
        rzmm = M.m512,
    }
}