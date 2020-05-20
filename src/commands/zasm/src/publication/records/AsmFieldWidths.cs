//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Linq;
    using System.Text;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    /// <summary>
    /// Defines the widths of common asm record fields
    /// </summary>
    public enum AsmFieldWidths
    {
        Id = 50,

        Sequence = 10,

        Count = 8,

        Mnemonic = 24,

        Instruction = 60,
        
        Register = 6,        

        Offset = 16,

        OpCode = 30,

        DataWidth = 26,

        OpKind = 12,

        Enc = 26,

        /// <summary>
        /// The width of a field containing an 8-bit decimal number
        /// </summary>
        Num8Dec = 8,

        /// <summary>
        /// The width of a field containing an 8-bit hex number
        /// </summary>
        Num8Hex = 8,

        /// <summary>
        /// The width of a field containing a boolean indicator [T/F, Y/N, 0/1, ..]
        /// </summary>
        Boolean = 8,

    }


}