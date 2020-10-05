//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    [Flags, FieldWidth(3)]
    public enum AsmOperandKind : byte
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
    }
}