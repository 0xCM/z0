//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IVsibAspects
    {
       //
        // Summary:
        //     Checks if this is a VSIB instruction, see also Iced.Intel.Instruction.IsVsib32,
        //     Iced.Intel.Instruction.IsVsib64
        bool IsVsib {get;}

        //
        // Summary:
        //     VSIB instructions only (Iced.Intel.Instruction.IsVsib): true if it's using 32-bit
        //     indexes, false if it's using 64-bit indexes
        bool IsVsib32 {get;}

        //
        // Summary:
        //     VSIB instructions only (Iced.Intel.Instruction.IsVsib): true if it's using 64-bit
        //     indexes, false if it's using 32-bit indexes
        bool IsVsib64 {get;}        
    }
}