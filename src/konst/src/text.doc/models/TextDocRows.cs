//-----------------------------------------------------------------------------
// Copyright   : (c) Chris Moore, 2020
// License     : MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TextDocRows
    {
        public readonly FS.FilePath Source;

        readonly TableSpan<TextRow> Data;

        [MethodImpl(Inline)]
        public TextDocRows(FS.FilePath src, TextRow[] rows)
        {
            Source = src;
            Data = rows;
        }

        public ref readonly TextRow this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }

        public bool IsEmpty
        {
            [MethodImpl(Inline)]
            get => Data.IsEmpty;
        }

        public bool IsNonEmpty
        {
            [MethodImpl(Inline), Op]
            get => Data.IsNonEmpty;
        }

        public uint RowCount
            => Data.Count;

        public ReadOnlySpan<TextRow> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public static TextDocRows Empty
        {
            [MethodImpl(Inline)]
            get => new TextDocRows(FS.FilePath.Empty, sys.empty<TextRow>());
        }
    }
}