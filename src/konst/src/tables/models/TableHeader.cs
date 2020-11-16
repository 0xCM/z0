//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableHeader : IIndex<HeaderCell>, ITextual
    {
        public HeaderCell[] Data {get;}

        [MethodImpl(Inline)]
        public TableHeader(HeaderCell[] data)
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
        {
            var dst = text.build();
            for(var i=0; i<Count; i++)
                dst.Append(text.format(RP.SlottedSpacePipe, Data[i].Format()));
            return dst.ToString();
        }

        [MethodImpl(Inline)]
        public static implicit operator TableHeader(HeaderCell[] data)
            => new TableHeader(data);

        public static TableHeader Empty
            => new TableHeader(sys.empty<HeaderCell>());
    }
}