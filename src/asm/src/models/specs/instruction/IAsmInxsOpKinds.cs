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
    /// Defines instruciton operand kind designation aspects
    /// </summary>
    public interface IAsmInxsOpKinds
    {
        //
        // Summary:
        //     Gets operand #0's kind if the operand exists (see Iced.Intel.Instruction.OpCount)
        OpKind Op0Kind {get; }
        //
        // Summary:
        //     Gets operand #1's kind if the operand exists (see Iced.Intel.Instruction.OpCount)
        OpKind Op1Kind {get;}
        //
        // Summary:
        //     Gets operand #2's kind if the operand exists (see Iced.Intel.Instruction.OpCount)
        OpKind Op2Kind {get;}
        //
        // Summary:
        //     Gets operand #3's kind if the operand exists (see Iced.Intel.Instruction.OpCount)
        OpKind Op3Kind {get;}

        //
        // Summary:
        //     Gets operand #4's kind if the operand exists (see Iced.Intel.Instruction.OpCount)
        OpKind Op4Kind {get;}
    }
}
