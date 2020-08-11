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
    
    using static Konst;

    /// <summary>
    /// Defines a contiguous *based* instruction sequence
    /// </summary>
    public readonly struct AsmInstructionList : IReadOnlyList<Instruction>
    {        
        readonly Instruction[] Source;

        public LocatedCode Encoded {get;}

        [MethodImpl(Inline)]
        public static implicit operator Instruction[](AsmInstructionList src)
            => src.Source;
         
        [MethodImpl(Inline)]
        public static AsmInstructionList Create(Instruction[] src, LocatedCode data)
            => new AsmInstructionList(src, data);

        [MethodImpl(Inline)]
        AsmInstructionList(Instruction[] instructions, LocatedCode data)
        {
            Source = instructions;
            Encoded = data;
        }

        Instruction IReadOnlyList<Instruction>.this[int index]  
        { 
            [MethodImpl(Inline)] 
            get => Source[index]; 
        }
        
        public ref readonly Instruction this[int index]  
        { 
            [MethodImpl(Inline)] 
            get => ref Source[index]; 
        }
        
        public Instruction[] Data
        {
            [MethodImpl(Inline)] 
            get => Source;
        }
        public int Count 
        { 
            [MethodImpl(Inline)] 
            get => Source.Length; 
        }

        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Source.Length; 
        }

        public bool IsEmpty 
        {
             [MethodImpl(Inline)] 
             get => Source == null || Source.Length == 0; 
        }

        public IEnumerator<Instruction> GetEnumerator()
            => ((IReadOnlyList<Instruction>)Source).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => Source.GetEnumerator();

        public static AsmInstructionList Empty 
            => new AsmInstructionList(z.array<Instruction>(), LocatedCode.Empty);

    }
}