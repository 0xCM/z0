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
        IceEncodingKind Encoding {get;}

        /// <summary>
        /// Encapsulates the result of ToInstructionCodeString() and ToInstructionString()
        /// </summary>
        AsmInstructionSpecExprLegacy Specifier {get;}

        //
        // Summary:
        //     Gets the code size when the instruction was decoded. This value is informational
        //     and can be used by a formatter.
        IceCodeSize CodeSize {get;}

        //
        // Summary:
        //     Gets the CPU or CPUID feature flags
        IceCpuidFeature[] CpuidFeatures {get; set;}

        /// <summary>
        /// Captures the op access array as specified by the InstructionInfo type
        /// </summary>
        Func<IceOpAccess[]> Access {get;}

    }
}