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
    using static z;

    /// <summary>
    /// Defines an *unbased* sequence of instructions
    /// </summary>         
    public readonly struct AsmInstructions : 
        IEnumerable<Instruction>, 
        IEncoded<AsmInstructions,BinaryCode>, 
        IEquatable<AsmInstructions>
    {
        readonly Instruction[] Fx;
        
        public BinaryCode Encoded {get;}

        public static AsmInstructions Empty 
            => Create(array<Instruction>(), BinaryCode.Empty);
        
        [MethodImpl(Inline)]
        public static AsmInstructions Create(Instruction[] src, BinaryCode data)
            => new AsmInstructions(src, data);

        public ref readonly Instruction this[int index]  
        { 
            [MethodImpl(Inline)] 
            get => ref Fx[index]; 
        }
        
        public int Length 
        { 
            [MethodImpl(Inline)] 
            get => Fx.Length; 
        }

        public int Count
        {
            [MethodImpl(Inline)] 
            get => Fx.Length;
        }

        public bool IsEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.IsEmpty; 
        }

        public bool IsNonEmpty 
        { 
            [MethodImpl(Inline)] 
            get => Encoded.IsNonEmpty; 
        }

        public static implicit operator Instruction[](AsmInstructions src)
            => src.Fx;

        [MethodImpl(Inline)]        
        internal AsmInstructions(Instruction[] src, BinaryCode data)
        {
            Fx = src;
            Encoded = data;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsmInstructions src)
            => Encoded.Equals(src.Encoded);
        public string Format()
            => Encoded.Format();
        
        public override string ToString()
            => Format();       
        IEnumerator<Instruction> IEnumerable<Instruction>.GetEnumerator()
            => Fx.AsEnumerable().GetEnumerator();        
        IEnumerator IEnumerable.GetEnumerator()
            => Fx.AsEnumerable().GetEnumerator();        
    }
}