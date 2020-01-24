//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.AsmSpecs
{        
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    
    using static zfunc;
        
    /// <summary>
    /// Encapsulates a contiguous instruction sequence
    /// </summary>
    public readonly struct AsmInstructionList : IReadOnlyList<Instruction>
    {
        readonly Instruction[] Instructions;


        public static implicit operator Instruction[](AsmInstructionList src)
            => src.Instructions;

        public static implicit operator AsmInstructionList(Instruction[] src)
            => Create(src);

        public static AsmInstructionList Create(Instruction[] src)
            => new AsmInstructionList(src);
         
        public static AsmInstructionList Create(IEnumerable<Instruction> src)
            => new AsmInstructionList(src.ToArray());

        AsmInstructionList(Instruction[] instructions)
            => this.Instructions = instructions;

        public Instruction this[int index] 
            => Instructions[index];

        public int Count 
            => Instructions.Length;

        public int Length
            => Instructions.Length;

        public IEnumerator<Instruction> GetEnumerator()
            => ((IReadOnlyList<Instruction>)Instructions).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => Instructions.GetEnumerator();
    }
}
