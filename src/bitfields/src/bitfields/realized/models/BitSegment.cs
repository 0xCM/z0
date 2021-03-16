//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Identifies a segment of bits within a context
    /// </summary>
    public readonly struct BitSegment
    {
        public ushort MinIndex {get;}

        public ushort BitCount {get;}

        [MethodImpl(Inline)]
        public BitSegment(ushort index, ushort count)
        {
            MinIndex = index;
            BitCount = count;
        }

        public ushort MaxIndex
        {
            [MethodImpl(Inline)]
            get => (ushort)(MinIndex + BitCount);
        }

        [MethodImpl(Inline)]
        public bool Equals(BitSegment src)
            => MinIndex == src.MinIndex && BitCount == src.BitCount;

        public string Format()
            => string.Format("{0}:{1}",MaxIndex, MinIndex);

        public override string ToString()
            => Format();

        public override bool Equals(object src)
            => src is BitSegment s && Equals(s);

        public override int GetHashCode()
            => MinIndex + BitCount;

        [MethodImpl(Inline)]
        public static implicit operator BitSegment((ushort min, ushort count) src)
            => new BitSegment(src.min, src.count);
    }
}