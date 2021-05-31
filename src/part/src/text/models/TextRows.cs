//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct TextRows : IIndex<TextRow>
    {
        readonly TextRow[] Data;

        [MethodImpl(Inline)]
        public TextRows(TextRow[] data)
            => Data = data;

        public TextRow[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public ReadOnlySpan<TextRow> Rows
        {
            [MethodImpl(Inline)]
            get => Data;
        }
        public ref readonly TextRow this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Rows[index];
        }

        [MethodImpl(Inline)]
        public ReadOnlySpan<TextRow> Slice(int offset)
            => Rows.Slice(offset);

        [MethodImpl(Inline)]
        public ReadOnlySpan<TextRow> Slice(int offset, int length)
            => Rows.Slice(offset, length);
    }
}