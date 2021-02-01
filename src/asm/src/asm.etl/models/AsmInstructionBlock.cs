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

    using static Part;
    using static z;

    /// <summary>
    /// Defines an *unbased* sequence of instructions
    /// </summary>
    public readonly struct AsmInstructionBlock : IEnumerable<IceInstruction>, IEquatable<AsmInstructionBlock>
    {
        readonly Index<IceInstruction> Instructions;

        public BinaryCode Data {get;}

        [MethodImpl(Inline)]
        internal AsmInstructionBlock(IceInstruction[] src, BinaryCode data)
        {
            Instructions = src;
            Data = data;
        }

        public ref readonly IceInstruction this[long index]
        {
            [MethodImpl(Inline)]
            get => ref Instructions[index];
        }

        public ref readonly IceInstruction this[ulong index]
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

        [MethodImpl(Inline)]
        public bool Equals(AsmInstructionBlock src)
            => Instructions.Equals(src.Instructions);

        public string Format()
            => Instructions.Format();

        public override string ToString()
            => Format();

        IEnumerator<IceInstruction> IEnumerable<IceInstruction>.GetEnumerator()
            => Instructions.AsEnumerable().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => Instructions.AsEnumerable().GetEnumerator();

        public static implicit operator IceInstruction[](AsmInstructionBlock src)
            => src.Instructions;

        public static AsmInstructionBlock Empty
            => new AsmInstructionBlock(array<IceInstruction>(), BinaryCode.Empty);
    }
}