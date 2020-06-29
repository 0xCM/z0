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
        public int FieldIndex {get;}

        /// <summary>
        /// The field name
        /// </summary>
        public string FieldName {get;}

        /// <summary>
        /// The number of bits covered by the field
        /// </summary>
        public Enum FieldWidth {get;}

        [MethodImpl(Inline)]
        public static bool operator ==(BitFieldIndexEntry lhs, BitFieldIndexEntry rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitFieldIndexEntry lhs, BitFieldIndexEntry rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal BitFieldIndexEntry(int index, string name, Enum width)
        {
            this.FieldIndex = index;
            this.FieldName = name;
            this.FieldWidth = width;
        }
        
        public string Format()
            => BitFieldSegmentFormatter.entry(this);

        [MethodImpl(Inline)]
        public bool Equals(BitFieldIndexEntry other)
            => FieldIndex == other.FieldIndex && FieldWidth.Equals(other.FieldWidth) && FieldName.Equals(other.FieldName);

        [MethodImpl(Inline)]
        public int CompareTo(BitFieldIndexEntry other)
            => FieldIndex.CompareTo(other.FieldIndex);
 
        public override string ToString()
            => Format();
           
        public override int GetHashCode()
            => HashCode.Combine(FieldIndex,FieldWidth);

        public override bool Equals(object obj)
            => obj is BitFieldIndexEntry x && Equals(x);
    }
}