//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;
                 
    /// <summary>
    /// Defines a contiguous instruction sequence
    /// </summary>
    public readonly struct AsmInstructionList : IReadOnlyList<Instruction>
    {        
        readonly Instruction[] Instructions;

        public static AsmInstructionList Empty = Create(new Instruction[0]{});

        [MethodImpl(Inline)]
        public static implicit operator Instruction[](AsmInstructionList src)
            => src.Instructions;

        [MethodImpl(Inline)]
        public static implicit operator AsmInstructionList(Instruction[] src)
            => Create(src);

        [MethodImpl(Inline)]
        public static AsmInstructionList Create(Instruction[] src)
            => new AsmInstructionList(src);
         
        [MethodImpl(Inline)]
        public static AsmInstructionList Create(IEnumerable<Instruction> src)
            => new AsmInstructionList(src.ToArray());

        [MethodImpl(Inline)]
        AsmInstructionList(Instruction[] instructions)
            => this.Instructions = instructions;

        public Instruction this[int index] 
        {
            [MethodImpl(Inline)]
            get => Instructions[index];
        }
        public int Count 
        {
            [MethodImpl(Inline)]
            get => Instructions.Length;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Instructions.Length;
        }

        public bool IsEmpty => Instructions == null || Instructions.Length == 0;

        public IEnumerator<Instruction> GetEnumerator()
            => ((IReadOnlyList<Instruction>)Instructions).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => Instructions.GetEnumerator();
    }
}
