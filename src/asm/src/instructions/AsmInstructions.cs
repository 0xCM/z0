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
        readonly Instruction[] Data;

        public BinaryCode Encoded {get;}

        public static AsmInstructions Empty
            => Create(array<Instruction>(), BinaryCode.Empty);

        [MethodImpl(Inline)]
        public static AsmInstructions Create(Instruction[] src, BinaryCode data)
            => new AsmInstructions(src, data);

        public ref readonly Instruction this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref readonly Instruction this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
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
            => src.Data;

        [MethodImpl(Inline)]
        internal AsmInstructions(Instruction[] src, BinaryCode data)
        {
            Data = src;
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
            => Data.AsEnumerable().GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => Data.AsEnumerable().GetEnumerator();
    }
}