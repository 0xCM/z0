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

    using static Konst;

    /// <summary>
    /// Defines a contiguous *based* instruction sequence
    /// </summary>
    public readonly struct AsmFxList : IEnumerable<Instruction>
    {
        readonly Instruction[] Source;

        public X86Code Encoded {get;}

        [MethodImpl(Inline)]
        public static implicit operator Instruction[](AsmFxList src)
            => src.Source;

        [MethodImpl(Inline)]
        public AsmFxList(Instruction[] src, X86Code data)
        {
            Source = src;
            Encoded = data;
        }

        public ref readonly Instruction this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Source[index];
        }

        public ReadOnlySpan<Instruction> View
        {
            [MethodImpl(Inline)]
            get => Source;
        }

        public Instruction[] Data
        {
            [MethodImpl(Inline)]
            get => Source;
        }

        public Count32 Count
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

        public static AsmFxList Empty
            => new AsmFxList(z.array<Instruction>(), X86Code.Empty);
    }
}