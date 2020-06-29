//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    

    /// <summary>
    /// Associates the declaration order of an enum literal with the corresponding literal value
    /// </summary>
    public readonly struct BitFieldIndexEntry<W> : IBitFieldIndexEntry<BitFieldIndexEntry<W>,W>
        where W : unmanaged, Enum
    {        
        public int FieldIndex {get;}

        public string FieldName {get;}

        public W FieldWidth {get;}

        [MethodImpl(Inline)]
        public static implicit operator BitFieldIndexEntry(BitFieldIndexEntry<W> src)
            => new BitFieldIndexEntry(src.FieldIndex, src.FieldName, src.FieldWidth);

        [MethodImpl(Inline)]
        public static bool operator ==(BitFieldIndexEntry<W> lhs, BitFieldIndexEntry<W> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitFieldIndexEntry<W> lhs, BitFieldIndexEntry<W> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal BitFieldIndexEntry(int index, string name, W width)
        {
            this.FieldIndex = index;
            this.FieldName = name;
            this.FieldWidth = width;
        }
        
        public string Format()
            => BitFieldSegmentFormatter.entry(this);
        
        [MethodImpl(Inline)]
        public bool Equals(BitFieldIndexEntry<W> other)
            => FieldIndex == other.FieldIndex && FieldWidth.Equals(other.FieldWidth)  && FieldName.Equals(other.FieldName);

        [MethodImpl(Inline)]
        public int CompareTo(BitFieldIndexEntry<W> other)
            => FieldIndex.CompareTo(other.FieldIndex);

        public override string ToString()
            => Format();
         
        public override int GetHashCode()
            => HashCode.Combine(FieldIndex,FieldWidth);

        public override bool Equals(object obj)
            => obj is BitFieldIndexEntry<W> x && Equals(x);
    }
}