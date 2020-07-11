//-----------------------------------------------------------------------------
// Derivative Work:  Derived from Iced:https://github.com/0xd4d/iced
// License:          See Iced license in the project root
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    public interface IInstructionOpCode 
    {
        //
        // Summary:
        //     Instruction code
        OpCodeId Code {get;}

        //
        // Summary:
        //     Gets the mnemonic
        Mnemonic Mnemonic {get;} 

        //
        // Summary:
        //     Gets the Iced.Intel.OpCodeInfo
        OpCodeInfo OpCode {get;}
   }
}