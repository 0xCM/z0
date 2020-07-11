//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines mask-related instruction aspects
    /// </summary>
    public interface IInstructionMasking
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