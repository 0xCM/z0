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
    public readonly struct AsmInstructions : IEnumerable<Instruction>, IEquatable<AsmInstructions>
    {
        readonly Index<Instruction> Instructions;

        public BinaryCode Data {get;}

        [MethodImpl(Inline)]
        public static AsmInstructions Create(Instruction[] src, BinaryCode data)
            => new AsmInstructions(src, data);

        public ref readonly Instruction this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Instructions[index];
        }

        public ref readonly Instruction this[ulong index]
        {
            [MethodImpl(Inline)]
            get => ref Instructions[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Instructions.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Instructions.Length;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Instructions.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Instructions.IsNonEmpty;
        }

        public static implicit operator Instruction[](AsmInstructions src)
            => src.Instructions;

        [MethodImpl(Inline)]
        internal AsmInstructions(Instruction[] src, BinaryCode data)
        {
            Instructions = src;
            Data = data;
        }

        [MethodImpl(Inline)]
        public bool Equals(AsmInstructions src)
            => Instructions.Equals(src.Instructions);
        public string Format()
            => Instructions.Format();

        public override string ToString()
            => Format();
        IEnumerator<Instruction> IEnumerable<Instruction>.GetEnumerator()
            => Instructions.AsEnumerable().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => Instructions.AsEnumerable().GetEnumerator();

        public static AsmInstructions Empty
            => Create(array<Instruction>(), BinaryCode.Empty);
    }
}