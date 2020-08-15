//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using M = MemOpKind;

    /// <summary>
    /// Classifies immediate operands
    /// </summary>
    public enum ImmOpKind : byte
    {
        None = 0,

        /// <summary>
        /// Designates an 8-bit immediate
        /// </summary>
        imm8 = M.m8,

        /// <summary>
        /// Designates a 16-bit immediate
        /// </summary>
        imm16 = M.m16,

        /// <summary>
        /// Designates a 32-bit immediate
        /// </summary>
        imm32 = M.m32,

        /// <summary>
        /// Designates a 64-bit immediate
        /// </summary>
        imm64 = M.m64,
    }
}