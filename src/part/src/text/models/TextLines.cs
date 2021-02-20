//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct TextLines : IIndex<TextLine>
    {
        readonly Index<TextLine> Data;

        [MethodImpl(Inline)]
        public TextLines(TextLine[] src)
            => Data = src;

        public ref TextLine First
        {
            [MethodImpl(Inline)]
            get => ref Data.First;
        }

        public TextLine[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
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

        public Span<TextLine> Edit
        {
            [MethodImpl(Inline)]
            get => Data.Edit;
        }

        public ReadOnlySpan<TextLine> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        [MethodImpl(Inline)]
        public static implicit operator TextLines(TextLine[] src)
            => new TextLines(src);

        [MethodImpl(Inline)]
        public static implicit operator TextLine[](TextLines src)
            => src.Storage;
    }
}