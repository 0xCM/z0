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
    /// Defines mask-related instruction aspects
    /// </summary>
    public interface IAsmInxsMask
    {
        //
        // Summary:
        //     Gets the opmask register (Iced.Intel.Register.K1 - Iced.Intel.Register.K7) or
        //     Iced.Intel.Register.None if none
        Register OpMask {get;}

        //
        // Summary:
        //     true if there's an opmask register (Iced.Intel.Instruction.OpMask)
        bool HasOpMask {get;}

        //
        // Summary:
        //     true if zeroing-masking, false if merging-masking. Only used by most EVEX encoded
        //     instructions that use opmask registers.
        bool ZeroingMasking {get;}
        
        //
        // Summary:
        //     true if merging-masking, false if zeroing-masking. Only used by most EVEX encoded
        //     instructions that use opmask registers.
        bool MergingMasking {get;}
    }
}