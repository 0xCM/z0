//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IAsmFxOpCode
    {
        //
        // Summary:
        //     Instruction code
        IceOpCodeId Code {get;}

        //
        // Summary:
        //     Gets the mnemonic
        IceMnemonic Mnemonic {get;}

        //
        // Summary:
        //     Gets the Iced.Intel.OpCodeInfo
        IceOpCodeInfo OpCode {get;}
   }
}