//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines branch-related instruction aspects
    /// </summary>
    public interface IInstructionBranch
    {
        //
        // Summary:
        //     Flow control info
        FlowControl FlowControl {get; set;}

        //
        // Summary:
        //     Gets the condition code if it's jcc, setcc, cmovcc else Iced.Intel.ConditionCode.None
        //     is returned
        ConditionCode ConditionCode {get;}

        //
        // Summary:
        //     Gets the operand's branch target. Use this property if the operand has kind Iced.Intel.OpKind.NearBranch16
        ushort NearBranch16 {get;}
        //
        // Summary:
        //     Gets the operand's branch target. Use this property if the operand has kind Iced.Intel.OpKind.NearBranch32
        uint NearBranch32 {get;}
        //
        // Summary:
        //     Gets the operand's branch target. Use this property if the operand has kind Iced.Intel.OpKind.NearBranch64
        ulong NearBranch64 {get;}
        //
        // Summary:
        //     Gets the near branch target if it's a call/jmp near branch instruction
        ulong NearBranchTarget {get;}
        //
        // Summary:
        //     Gets the operand's branch target. Use this property if the operand has kind Iced.Intel.OpKind.FarBranch16
        ushort FarBranch16 {get;}
        //
        // Summary:
        //     Gets the operand's branch target. Use this property if the operand has kind Iced.Intel.OpKind.FarBranch32
        uint FarBranch32 {get;}

        //
        // Summary:
        //     Gets the operand's branch target selector. Use this property if the operand has
        //     kind Iced.Intel.OpKind.FarBranch16 or Iced.Intel.OpKind.FarBranch32
        ushort FarBranchSelector {get;}
    }
}