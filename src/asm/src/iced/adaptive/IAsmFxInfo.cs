//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public interface IAsmFxInfo :
        IAsmFxFlags,
        IAsmFxBranching,
        IAsmFxImm,
        ILazyAsmFxInfo,
        IAsmFxIp,
        IAsmFxMasking,
        IAsmFxMemory,
        IAsmFxOpCode,
        IAsmOperandKinds,
        IAsmFxPrefix,
        IAsmFxRegisters,
        IAsmVsibAspects
    {
        //
        // Summary:
        //     Gets the number of operands
        int OpCount {get;}

        /// <summary>
        /// Captures the formatted view of the instruction
        /// </summary>
        string FormattedInstruction {get;}

        //
        // Summary:
        //     Gets the length of the instruction, 0-15 bytes. This is just informational. If
        //     you modify the instruction or create a new one, this property could return the
        //     wrong value.
        int ByteLength {get;}

        //
        // Summary:
        //     Rounding control (Iced.Intel.Instruction.SuppressAllExceptions is implied but
        //     still returns false) or Iced.Intel.RoundingControl.None if the instruction doesn't
        //     use it.
        RoundingControl RoundingControl {get;}

        //
        // Summary:
        //     Number of elements in a db/dw/dd/dq directive. Can only be called if Iced.Intel.Instruction.Code
        //     is Iced.Intel.Code.DeclareByte, Iced.Intel.Code.DeclareWord, Iced.Intel.Code.DeclareDword,
        //     Iced.Intel.Code.DeclareQword
        int DeclareDataCount {get;}

        //
        // Summary:
        //     true if the instruction isn't available in real mode or virtual 8086 mode
        bool IsProtectedMode {get;}

        //
        // Summary:
        //     true if this is a privileged instruction
        bool IsPrivileged {get;}

        //
        // Summary:
        //     Suppress all exceptions (EVEX encoded instructions). Note that if Iced.Intel.Instruction.RoundingControl
        //     is not Iced.Intel.RoundingControl.None, SAE is implied but this property will
        //     still return false.
        bool SuppressAllExceptions {get;}

        //
        // Summary:
        //     true if it's an instruction that saves or restores too many registers (eg. fxrstor,
        //     xsave, etc).
        bool IsSaveRestoreInstruction {get;}

        //
        // Summary:
        //     true if the data is broadcasted (EVEX instructions only)
        bool IsBroadcast {get;}
    }
}