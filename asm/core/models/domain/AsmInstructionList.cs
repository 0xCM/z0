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
    
    using static root;
                 
    /// <summary>
    /// Defines a contiguous instruction sequence
    /// </summary>
    public readonly struct AsmInstructionList : IReadOnlyList<Instruction>
    {        
        readonly Instruction[] Instructions;

        public readonly MemoryExtract EncodedBytes;

        public static AsmInstructionList Empty = new AsmInstructionList(new Instruction[0]{}, MemoryExtract.Empty);

        [MethodImpl(Inline)]
        public static implicit operator Instruction[](AsmInstructionList src)
            => src.Instructions;

        // [MethodImpl(Inline)]
        // public static AsmInstructionList Create(Instruction[] src)
        //     => new AsmInstructionList(src);
         
        // [MethodImpl(Inline)]
        // public static AsmInstructionList Create(Instruction[] src, byte[] data)
        //     => new AsmInstructionList(src, data);
         
        [MethodImpl(Inline)]
        public static AsmInstructionList Create(Instruction[] src, MemoryExtract data)
            => new AsmInstructionList(src, data);

        // [MethodImpl(Inline)]
        // AsmInstructionList(Instruction[] instructions)
        // {
        //     this.Instructions = instructions;
        //     this.EncodedBytes = EncodedData.Empty;
        // }

        [MethodImpl(Inline)]
        AsmInstructionList(Instruction[] instructions, MemoryExtract data)
        {
            this.Instructions = instructions;
            this.EncodedBytes = data;
        }

        // [MethodImpl(Inline)]
        // AsmInstructionList(Instruction[] instructions, byte[] data)
        // {
        //     this.Instructions = instructions;
        //     this.EncodedBytes =  
        //         instructions.Length != 0 ?  
        //         EncodedData.Define(instructions[0].IP, data) 
        //         : EncodedData.Empty;
        // }
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