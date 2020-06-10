//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    [Flags, FieldWidth(3)]
    public enum OperandKind : byte
    {
        /// <summary>
        /// Unclassified
        /// </summary>
        Null = 0,

        /// <summary>
        /// Classifies a register operand
        /// </summary>
        R = 0b001,

        /// <summary>
        /// Classifies a memory operand
        /// </summary>
        M = 0b010,

        /// <summary>
        /// Classifies an immediate operand
        /// </summary>
        Imm = 0b100,

        /// <summary>
        /// Classifies an r/m operand
        /// </summary>
        RM = R | M,        
    }
}