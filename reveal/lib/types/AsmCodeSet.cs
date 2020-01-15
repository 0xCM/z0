//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Iced.Intel;

    public class AsmCodeSet
    {
        public static AsmCodeSet Define(Moniker moniker, InstructionBlock asm, CilFunction cil)
            => new AsmCodeSet(moniker, asm,cil);

        AsmCodeSet(Moniker moniker, InstructionBlock instructions, CilFunction cil)
        {
            this.Moniker = moniker;
            this.Label = instructions.Label;
            this.Decoded = instructions;
            this.Cil = cil;
            this.Encoded = AsmCode.Load(instructions.Encoded, moniker);            
        }

        public Moniker Moniker {get;}    

        public string Label {get;}    

        public AsmCode Encoded {get;}

        public InstructionBlock Decoded {get;}

        public CilFunction Cil {get;}

        public int InstructionCount 
            => Decoded.InstructionCount;
        
        public int EncodedByteCount
            => Encoded.Data.Length;
    
        public ulong BaseAddress
            => Decoded[0].IP;       

        public string Format()
            => Decoded.Format();
    }
}