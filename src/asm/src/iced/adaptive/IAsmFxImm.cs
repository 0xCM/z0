//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Defines imm-related instruction aspects
    /// </summary>
    public interface IAsmFxImm
    {
        //
        // Summary:
        //     Gets the operand's immediate value. Use this property if the operand has kind
        //     Iced.Intel.OpKind.Immediate8
        byte Immediate8 {get;}
        //
        // Summary:
        //     Gets the operand's immediate value. Use this property if the operand has kind
        //     Iced.Intel.OpKind.Immediate8_2nd
        byte Immediate8_2nd {get;}
        //
        // Summary:
        //     Gets the operand's immediate value. Use this property if the operand has kind
        //     Iced.Intel.OpKind.Immediate16
        ushort Immediate16 {get;}
        //
        // Summary:
        //     Gets the operand's immediate value. Use this property if the operand has kind
        //     Iced.Intel.OpKind.Immediate32
        uint Immediate32 {get;}
        //
        // Summary:
        //     Gets the operand's immediate value. Use this property if the operand has kind
        //     Iced.Intel.OpKind.Immediate64
        ulong Immediate64 {get;}
        //
        // Summary:
        //     Gets the operand's immediate value. Use this property if the operand has kind
        //     Iced.Intel.OpKind.Immediate8to16
        short Immediate8to16 {get;}
        //
        // Summary:
        //     Gets the operand's immediate value. Use this property if the operand has kind
        //     Iced.Intel.OpKind.Immediate8to32
        int Immediate8to32 {get;}
        //
        // Summary:
        //     Gets the operand's immediate value. Use this property if the operand has kind
        //     Iced.Intel.OpKind.Immediate8to64
        long Immediate8to64 {get;}
        //
        // Summary:
        //     Gets the operand's immediate value. Use this property if the operand has kind
        //     Iced.Intel.OpKind.Immediate32to64
        long Immediate32to64 {get;}
    }
}