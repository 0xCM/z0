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
    /// Defines an *unbased* sequence of instructions
    /// </summary>         
    public readonly struct AsmInstructions : 
        IEnumerable<Instruction>, 
        IEncoded<AsmInstructions,BinaryCode>, 
        IEquatable<AsmInstructions>
    {
        [MethodImpl(Inline)]
        public static AsmInstructions Create(Instruction[] src, BinaryCode data)
            => new AsmInstructions(src, data);

        readonly Instruction[] Inxs;
        
        public BinaryCode Encoded {get;}

        public ref readonly Instruction this[int index]  { [MethodImpl(Inline)] get => ref Inxs[index]; }
        
        public int Length { [MethodImpl(Inline)] get => Inxs.Length; }

        public bool IsEmpty { [MethodImpl(Inline)] get => Encoded.IsEmpty; }

        public bool IsNonEmpty { [MethodImpl(Inline)] get => Encoded.IsNonEmpty; }

        public ReadOnlySpan<byte> Bytes { [MethodImpl(Inline)] get => Encoded.Bytes; }

        public static implicit operator Instruction[](AsmInstructions src)
            => src.Inxs;

        [MethodImpl(Inline)]        
        internal AsmInstructions(Instruction[] src, BinaryCode data)
        {
            Inxs = src;
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
            => Inxs.AsEnumerable().GetEnumerator();        
        IEnumerator IEnumerable.GetEnumerator()
            => Inxs.AsEnumerable().GetEnumerator();        
    }
}