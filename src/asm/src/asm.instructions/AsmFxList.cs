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
    public readonly struct AsmFxList : IEnumerable<IceInstruction>
    {
        readonly IceInstruction[] Source;

        public CodeBlock Encoded {get;}

        [MethodImpl(Inline)]
        public static implicit operator IceInstruction[](AsmFxList src)
            => src.Source;

        [MethodImpl(Inline)]
        public AsmFxList(IceInstruction[] src, CodeBlock data)
        {
            Source = src;
            Encoded = data;
        }

        public ref readonly IceInstruction this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Source[index];
        }

        public ReadOnlySpan<IceInstruction> View
        {
            [MethodImpl(Inline)]
            get => Source;
        }

        public IceInstruction[] Data
        {
            [MethodImpl(Inline)]
            get => Source;
        }

        public Count Count
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

        public IEnumerator<IceInstruction> GetEnumerator()
            => ((IReadOnlyList<IceInstruction>)Source).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator()
            => Source.GetEnumerator();

        public static AsmFxList Empty
            => new AsmFxList(z.array<IceInstruction>(), CodeBlock.Empty);
    }
}