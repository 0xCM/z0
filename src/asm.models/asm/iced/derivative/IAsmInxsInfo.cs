//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IAsmInxsInfo
    {
        //
        // Summary:
        //     Instruction encoding, eg. legacy, VEX, EVEX, ...
        EncodingKind Encoding {get;}

        /// <summary>
        /// Encapsulates the result of ToInstructionCodeString() and ToInstructionString()
        /// </summary>
        AsmFxCode InstructionCode {get;}

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
        /// Retrieves the used memory array as specified by the InstructionInfo type
        /// </summary>
        Func<UsedMemory[]> UsedMemory {get;}

        /// <summary>
        /// Captures the used register array as specified by the InstructionInfo type
        /// </summary>
        Func<UsedRegister[]> UsedRegisters {get;}

        /// <summary>
        /// Captures the op access array as specified by the InstructionInfo type
        /// </summary>
        Func<OpAccess[]> Access {get;}

        /// <summary>
        /// Computes flow information upon request
        /// </summary>
        Func<AsmFlowInfo> FlowInfo {get;}
    }
}