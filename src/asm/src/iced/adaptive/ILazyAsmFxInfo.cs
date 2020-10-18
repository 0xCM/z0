//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface ILazyAsmFxInfo
    {
        //
        // Summary:
        //     Instruction encoding, eg. legacy, VEX, EVEX, ...
        EncodingKind Encoding {get;}

        /// <summary>
        /// Encapsulates the result of ToInstructionCodeString() and ToInstructionString()
        /// </summary>
        AsmSpecifier InstructionCode {get;}

        //
        // Summary:
        //     Gets the code size when the instruction was decoded. This value is informational
        //     and can be used by a formatter.
        CodeSize CodeSize {get;}

        //
        // Summary:
        //     Gets the CPU or CPUID feature flags
        CpuidFeature[] CpuidFeatures {get; set;}

        /// <summary>
        /// Captures the op access array as specified by the InstructionInfo type
        /// </summary>
        Func<OpAccess[]> Access {get;}

    }
}