//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;

    using C = TabularWidths;

    /// <summary>
    /// Defines the widths of common asm record fields
    /// </summary>
    public enum AsmFieldWidths
    {
        Id = 50,

        Sequence = C.Sequence,

        Count = C.Count,

        Mnemonic = asci16.Size,

        Instruction = asci32.Size,

        OpCode = asci32.Size,

        Register = 6,        

        Offset = 16,

        OpCodeBytes = 16,

        Operand = 20,

        DataWidth = 26,

        OpKind = 12,

        Enc = 26,

        Address16 = 6,

        Address32 = 12,

        Address64 = 16,

        YeaOrNea = C.Bool,

        /// <summary>
        /// The width of a field containing an 8-bit decimal number
        /// </summary>
        Num8Dec = C.Num8Dec,

        /// <summary>
        /// The width of a field containing an 8-bit hex number
        /// </summary>
        Num8Hex = C.Num8Hex,

        /// <summary>
        /// The width of a field containing a boolean indicator [T/F, Y/N, 0/1, ..] that has a small label
        /// </summary>
        BoolSmall = C.Bool,

        /// <summary>
        /// The width of a field containing a boolean indicator [T/F, Y/N, 0/1, ..] that has a large label
        /// </summary>
        BoolLarge = C.BoolLarge,

        CpuId = asci16.Size,
    }
}