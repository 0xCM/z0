//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public interface IAsmInxsInfo
    {
        //
        // Summary:
        //     Instruction encoding, eg. legacy, VEX, EVEX, ...
        EncodingKind Encoding {get;}

        /// <summary>
        /// Encapsulates the result of ToInstructionCodeString() and ToInstructionString()
        /// </summary>
        AsmInstructionCode InstructionCode {get;}

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