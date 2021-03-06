//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    /// <summary>
    /// Associates the declaration order of an enum literal with the corresponding literal value
    /// </summary>
    public readonly struct BitFieldIndexEntry<W> : IBitFieldIndexEntry<BitFieldIndexEntry<W>,W>
        where W : unmanaged
    {
        public uint FieldIndex {get;}

        public string FieldName {get;}

        public W FieldWidth {get;}

        [MethodImpl(Inline)]
        public BitFieldIndexEntry(uint index, string name, W width)
        {
            FieldIndex = index;
            FieldName = name;
            FieldWidth = width;
        }

        [MethodImpl(Inline)]
        public bool Equals(BitFieldIndexEntry<W> other)
            => FieldIndex == other.FieldIndex && FieldWidth.Equals(other.FieldWidth)  && FieldName.Equals(other.FieldName);

        [MethodImpl(Inline)]
        public int CompareTo(BitFieldIndexEntry<W> other)
            => FieldIndex.CompareTo(other.FieldIndex);


        public override int GetHashCode()
            => HashCode.Combine(FieldIndex,FieldWidth);

        public override bool Equals(object obj)
            => obj is BitFieldIndexEntry<W> x && Equals(x);

        [MethodImpl(Inline)]
        public static implicit operator BitFieldIndexEntry(BitFieldIndexEntry<W> src)
            => new BitFieldIndexEntry(src.FieldIndex, src.FieldName, uint32(src.FieldWidth));

        [MethodImpl(Inline)]
        public static bool operator ==(BitFieldIndexEntry<W> a, BitFieldIndexEntry<W> b)
            => a.Equals(b);

        [MethodImpl(Inline)]
        public static bool operator !=(BitFieldIndexEntry<W> lhs, BitFieldIndexEntry<W> rhs)
            => !lhs.Equals(rhs);

    }
}