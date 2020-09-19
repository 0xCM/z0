//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct BitFieldIndexEntry : IBitFieldIndexEntry<BitFieldIndexEntry>
    {
        /// <summary>
        /// The zero-based and sequential field index
        /// </summary>
        public uint FieldIndex {get;}

        /// <summary>
        /// The field name
        /// </summary>
        public string FieldName {get;}

        /// <summary>
        /// The number of bits covered by the field
        /// </summary>
        public uint FieldWidth {get;}

        [MethodImpl(Inline)]
        public static bool operator ==(BitFieldIndexEntry lhs, BitFieldIndexEntry rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitFieldIndexEntry lhs, BitFieldIndexEntry rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public BitFieldIndexEntry(uint index, string name, uint width)
        {
            FieldIndex = index;
            FieldName = name;
            FieldWidth = width;
        }

        [MethodImpl(Inline)]
        public bool Equals(BitFieldIndexEntry other)
            => FieldIndex == other.FieldIndex && FieldWidth.Equals(other.FieldWidth) && FieldName.Equals(other.FieldName);

        [MethodImpl(Inline)]
        public int CompareTo(BitFieldIndexEntry other)
            => FieldIndex.CompareTo(other.FieldIndex);

        public override int GetHashCode()
            => HashCode.Combine(FieldIndex,FieldWidth);

        public override bool Equals(object obj)
            => obj is BitFieldIndexEntry x && Equals(x);
    }
}