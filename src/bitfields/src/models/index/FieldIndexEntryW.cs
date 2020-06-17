//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;    
    using static Memories;

    /// <summary>
    /// Associates the declaration order of an enum literal with the corresponding literal value
    /// </summary>
    public readonly struct FieldIndexEntry<W> : IFieldIndexEntry<FieldIndexEntry<W>,W>
        where W : unmanaged, Enum
    {        
        public int FieldIndex {get;}

        public string FieldName {get;}

        public W FieldWidth {get;}

        [MethodImpl(Inline)]
        public static implicit operator FieldIndexEntry(FieldIndexEntry<W> src)
            => new FieldIndexEntry(src.FieldIndex, src.FieldName, src.FieldWidth);

        [MethodImpl(Inline)]
        public static bool operator ==(FieldIndexEntry<W> lhs, FieldIndexEntry<W> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(FieldIndexEntry<W> lhs, FieldIndexEntry<W> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal FieldIndexEntry(int index, string name, W width)
        {
            this.FieldIndex = index;
            this.FieldName = name;
            this.FieldWidth = width;
        }
        
        public string Format()
            => SegmentFormatter.entry(this);
        
        [MethodImpl(Inline)]
        public bool Equals(FieldIndexEntry<W> other)
            => FieldIndex == other.FieldIndex && FieldWidth.Equals(other.FieldWidth)  && FieldName.Equals(other.FieldName);

        [MethodImpl(Inline)]
        public int CompareTo(FieldIndexEntry<W> other)
            => FieldIndex.CompareTo(other.FieldIndex);

        public override string ToString()
            => Format();
         
        public override int GetHashCode()
            => HashCode.Combine(FieldIndex,FieldWidth);

        public override bool Equals(object obj)
            => obj is FieldIndexEntry<W> x && Equals(x);
    }
}