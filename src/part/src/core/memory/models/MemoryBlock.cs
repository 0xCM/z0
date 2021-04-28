    //-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MemoryBlock : IComparable<MemoryBlock>
    {
        public MemoryRange Origin {get;}

        readonly Index<byte> Data;

        [MethodImpl(Inline)]
        public MemoryBlock(MemoryRange origin, Index<byte> data)
        {
            Origin = origin;
            Data = data;
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

        public MemoryAddress BaseAddress
        {
            [MethodImpl(Inline)]
            get => Origin.Min;
        }

        public ReadOnlySpan<byte> View
        {
            [MethodImpl(Inline)]
            get => Data.View;
        }

        public ByteSize Size
        {
            [MethodImpl(Inline)]
            get => Origin.Size;
        }

        public int CompareTo(MemoryBlock src)
            => Origin.Min.CompareTo(src.Origin.Min);

        public static MemoryBlock Empty
        {
            [MethodImpl(Inline)]
            get => new MemoryBlock(MemoryRange.Empty, Index<byte>.Empty);
        }
    }
}