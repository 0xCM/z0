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

    public class AsmCodeSet
    {
        public static AsmCodeSet Define(Moniker moniker, InstructionBlock asm, CilFunctionBody cil)
            => new AsmCodeSet(moniker, asm,cil);

        AsmCodeSet(Moniker id, InstructionBlock instructions, CilFunctionBody cil)
        {
            this.Id = id;
            this.Label = instructions.Label;
            this.Decoded = instructions;
            this.Cil = cil;
            this.Encoded = AsmCode.Define(id, instructions.Label,instructions.Encoded);   
            var count = instructions.InstructionCount;
            this.Location = MemoryRange.Define(instructions[0].IP, instructions[count - 1].IP + (ulong)instructions[count - 1].ByteLength);
         
        }

        public Moniker Id {get;}    

        public string Label {get;}    

        public AsmCode Encoded {get;}

        public MemoryRange Location {get;}

        public InstructionBlock Decoded {get;}

        public CilFunctionBody Cil {get;}

    }
}