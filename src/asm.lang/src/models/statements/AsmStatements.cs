//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct AsmStatements
    {
        readonly Index<AsmStatement> Data;

        [MethodImpl(Inline)]
        public AsmStatements(AsmStatement[] src)
            => Data = src;

        public uint Count
        {
            [MethodImpl(Inline)]
            get => Data.Count;
        }

        [MethodImpl(Inline)]
        public static implicit operator AsmStatements(AsmStatement[] src)
            => new AsmStatements(src);

        [MethodImpl(Inline)]
        public static implicit operator AsmStatement[](AsmStatements src)
            => src.Data;

        public ReadOnlySpan<AsmStatement> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public Span<AsmStatement> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ref AsmStatement First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }
    }
}