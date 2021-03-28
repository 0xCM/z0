//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmStatements : IIndex<AsmStatement>
    {
        readonly Index<AsmStatement> Data;

        [MethodImpl(Inline)]
        public AsmStatements(AsmStatement[] src)
            => Data = src;
        public AsmStatement[] Storage
        {
            [MethodImpl(Inline)]
            get => Data.Storage;
        }

        public ref AsmStatement First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public Span<AsmStatement> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<AsmStatement> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsNonEmpty;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmStatement[](AsmStatements src)
            => src.Data;

        [MethodImpl(Inline)]
        public static implicit operator AsmStatements(AsmStatement[] src)
            => new AsmStatements(src);

        public static AsmStatements Empty
        {
            [MethodImpl(Inline)]
            get => sys.empty<AsmStatement>();
        }
    }
}