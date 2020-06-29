//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IInstructionRegisters
    {
        //
        // Summary:
        //     Gets operand #0's register value. Use this property if operand #0 (Iced.Intel.Instruction.Op0Kind)
        //     has kind Iced.Intel.OpKind.Register
        Register Op0Register {get;}
        //
        // Summary:
        //     Gets operand #1's register value. Use this property if operand #1 (Iced.Intel.Instruction.Op1Kind)
        //     has kind Iced.Intel.OpKind.Register
        Register Op1Register {get;}

        //
        // Summary:
        //     Gets operand #2's register value. Use this property if operand #2 (Iced.Intel.Instruction.Op2Kind)
        //     has kind Iced.Intel.OpKind.Register
        Register Op2Register {get;}
        //
        // Summary:
        //     Gets operand #3's register value. Use this property if operand #3 (Iced.Intel.Instruction.Op3Kind)
        //     has kind Iced.Intel.OpKind.Register
        Register Op3Register {get;}
        //
        // Summary:
        //     Gets operand #4's register value. Use this property if operand #4 (Iced.Intel.Instruction.Op4Kind)
        //     has kind Iced.Intel.OpKind.Register
        Register Op4Register {get;}

    }
}
