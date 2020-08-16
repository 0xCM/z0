//-----------------------------------------------------------------------------
// Derived from Iced:https://github.com/0xd4d/iced
// License: See the accompanying license file
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Diagnostics;

    public struct AsmFxData
    {

        /// <summary>
        /// Encapsulates the result of ToInstructionCodeString() and ToInstructionString()
        /// </summary>
        public AsmInstructionCode InstructionCode;

        /// <summary>
        /// Captures the formatted view of the instruction
        /// </summary>
        public string FormattedInstruction;

        /// <summary>
        /// Retrieves the used memory array as specified by the InstructionInfo type
        /// </summary>
        public Func<UsedMemory[]> UsedMemory;

        /// <summary>
        /// Captures the used register array as specified by the InstructionInfo type
        /// </summary>
        public Func<UsedRegister[]> UsedRegisters {get; set;}

        /// <summary>
        /// Captures the op access array as specified by the InstructionInfo type
        /// </summary>
        public Func<OpAccess[]> Access {get;set;}

        /// <summary>
        /// Computes flow information upon request
        /// </summary>
        public Func<AsmFlowInfo> FlowInfo {get;set;}
        
        //
        // Summary:
        //     Gets the condition code if it's jcc, setcc, cmovcc else Iced.Intel.ConditionCode.None
        //     is returned
        public ConditionCode ConditionCode {get; set;}

    }
}