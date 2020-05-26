//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
 
    /// <summary>
    /// Defines instruction operand classifiers
    /// </summary>
    public enum OperandClass : byte
    {
        /// <summary>
        /// Classifies nothing
        /// </summary>
        None = 0,

        /// <summary>
        /// Classifies a memory operand
        /// </summary>
        m = 0b001,

        /// <summary>
        /// Classifies a register operand
        /// </summary>
        r = 0b010,

        /// <summary>
        /// Classifies an immediate operand
        /// </summary>
        imm = 0b100,

        /// <summary>
        /// Classifies a register/memory operand
        /// </summary>
        rm =  r | m,
    }
}