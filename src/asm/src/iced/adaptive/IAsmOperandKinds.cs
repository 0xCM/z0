//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines instruction operand kind designation aspects
    /// </summary>
    public interface IAsmOperandKinds
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
