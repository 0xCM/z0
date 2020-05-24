//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    using M = MemOpKind;

    /// <summary>
    /// Classifies register operands
    /// </summary>
    public enum RegOpKind : byte
    {
        None,

        /// <summary>
        /// Designates an 8-bit register
        /// </summary>
        r8 = M.m8,

        /// <summary>
        /// Designates a 16-bit register
        /// </summary>
        r16 = M.m16,

        /// <summary>
        /// Designates a 32-bit register
        /// </summary>
        r32 = M.m32,

        /// <summary>
        /// Designates a 64-bit register
        /// </summary>
        r64 = M.m64,

        /// <summary>
        /// Designates a 128-bit xmm register
        /// </summary>
        xmm = M.m128,

        /// <summary>
        /// Designates a 256-bit ymm register
        /// </summary>
        ymm = M.m256,

        /// <summary>
        /// Designates a 512-bit zmm register
        /// </summary>
        zmm = M.m512,
    }
}