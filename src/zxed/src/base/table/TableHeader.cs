//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct TableHeader
    {        
        public readonly TableHeaderCell[] Data;

        [MethodImpl(Inline)]
        public static implicit operator TableHeader(TableHeaderCell[] data)
            => new TableHeader(data);

        [MethodImpl(Inline)]
        public TableHeader(TableHeaderCell[] data)
            => Data = data;

        public ref TableHeaderCell this[uint index]
        {
            [MethodImpl(Inline)]
            get => ref Data[index];
        }

        public ref TableHeaderCell this[int index]
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
    }
}