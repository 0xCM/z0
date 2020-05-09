//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IInstructionVsib
    {
       //
        // Summary:
        //     Checks if this is a VSIB instruction, see also Iced.Intel.Instruction.IsVsib32,
        //     Iced.Intel.Instruction.IsVsib64
        bool IsVsib {get;}

        //
        // Summary:
        //     VSIB instructions only (Iced.Intel.Instruction.IsVsib): true if it's using 32-bit
        //     indexes, false if it's using 64-bit indexes
        bool IsVsib32 {get;}

        //
        // Summary:
        //     VSIB instructions only (Iced.Intel.Instruction.IsVsib): true if it's using 64-bit
        //     indexes, false if it's using 32-bit indexes
        bool IsVsib64 {get;}        
    }
}