//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct RowHeader : IIndex<HeaderCell>, ITextual
    {
        public HeaderCell[] Data {get;}

        [MethodImpl(Inline)]
        public RowHeader(HeaderCell[] data)
            => Data = data;

        public HeaderCell[] Storage
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref HeaderCell this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref HeaderCell this[int index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public uint Count
        {
            [MethodImpl(Inline)]
            get => (uint)Data.Length;
        }

        public string Format()
            => RowFormat.format(this);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator RowHeader(HeaderCell[] data)
            => new RowHeader(data);

        public static RowHeader Empty
            => new RowHeader(sys.empty<HeaderCell>());
    }
}