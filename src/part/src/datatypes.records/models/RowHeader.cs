//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    using api = RecordUtilities;

    public readonly struct RowHeader : IIndex<HeaderCell>, ITextual
    {
        public HeaderCell[] Cells {get;}

        public string Delimiter {get;}

        [MethodImpl(Inline)]
        public RowHeader(HeaderCell[] data, string delimiter)
        {
            Cells = data;
            Delimiter = delimiter;
        }

        public HeaderCell[] Storage
        {
            [MethodImpl(Inline)]
            get => Cells;
        }

        public ref HeaderCell this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }

        public ref HeaderCell this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Cells[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Cells.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Cells.Length;
        }

        public string Format()
            => api.format(this);

        public override string ToString()
            => Format();

        public static RowHeader Empty
            => new RowHeader(sys.empty<HeaderCell>(), EmptyString);
    }
}