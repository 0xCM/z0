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
    
    using static Seed;

    /// <summary>
    /// Defines a contiguous *based* instruction sequence
    /// </summary>
    public readonly struct AsmInstructionList : IReadOnlyList<Instruction>
    {        
        public static AsmInstructionList Empty = new AsmInstructionList(Control.array<Instruction>(), LocatedCode.Empty);

        readonly Instruction[] Instructions;

        public LocatedCode Encoded {get;}

        [MethodImpl(Inline)]
        public static implicit operator Instruction[](AsmInstructionList src)
            => src.Instructions;
         
        [MethodImpl(Inline)]
        public static AsmInstructionList Create(Instruction[] src, LocatedCode data)
            => new AsmInstructionList(src, data);

        [MethodImpl(Inline)]
        AsmInstructionList(Instruction[] instructions, LocatedCode data)
        {
            this.Instructions = instructions;
            this.Encoded = data;
        }

        public Instruction this[int index]  { [MethodImpl(Inline)] get => Instructions[index]; }
        
        public int Count { [MethodImpl(Inline)] get => Instructions.Length; }

        public int Length { [MethodImpl(Inline)] get => Instructions.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Instructions == null || Instructions.Length == 0; }

        public IEnumerator<Instruction> GetEnumerator()
            => ((IReadOnlyList<Instruction>)Instructions).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => Instructions.GetEnumerator();
    }
}