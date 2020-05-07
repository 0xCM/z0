//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines flag-related instruction aspects
    /// </summary>
    public interface IAsmInxsFlags
    {
        //
        // Summary:
        //     All flags that are read by the CPU when executing the instruction
        RflagsBits RflagsRead {get;}
        //
        // Summary:
        //     All flags that are written by the CPU, except those flags that are known to be
        //     undefined, always set or always cleared. See also Iced.Intel.Instruction.RflagsModified
        RflagsBits RflagsWritten {get;}
        //
        // Summary:
        //     All flags that are always cleared by the CPU
        RflagsBits RflagsCleared {get;}
        //
        // Summary:
        //     All flags that are always set by the CPU
        RflagsBits RflagsSet {get;}
        //
        // Summary:
        //     All flags that are undefined after executing the instruction
        RflagsBits RflagsUndefined {get;}
        //
        // Summary:
        //     All flags that are modified by the CPU. This is Iced.Intel.Instruction.RflagsWritten
        //     + Iced.Intel.Instruction.RflagsCleared + Iced.Intel.Instruction.RflagsSet + Iced.Intel.Instruction.RflagsUndefined
        RflagsBits RflagsModified {get;}
    }
}
