//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    /// <summary>
    /// Classifies branch expressions
    /// </summary>
    [Flags]
    public enum AsmBranchKind : byte
    {
        None,

        /// <summary>
        /// Classifies statements of the form (jmp near) | (jmp far)
        /// </summary>
        Unconditional = 1,

        /// <summary>
        /// Classifies statements of the form (jcc short) | (jcc near) | (loop) | (loopcc) | (jrcxz)
        /// </summary>
        Conditional = 2,

        /// <summary>
        /// Classifies statements of the form (jmp near reg) | (jmp near [mem]) | (jmp far [mem])
        /// </summary>
        Indirect = 4,
    }
}