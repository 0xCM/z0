//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;


    public interface IAsmInxsOpCode 
    {
        //
        // Summary:
        //     Instruction code
        Code Code {get;}

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