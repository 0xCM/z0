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
    public readonly struct FieldIndexEntry<E,W> : IFieldIndexEntry<FieldIndexEntry<E,W>,E,W>
        where E : unmanaged, Enum
        where W : unmanaged, Enum
    {        
        public E FieldIndex {get;}

        public string FieldName {get;}

        public W FieldWidth {get;}

        [MethodImpl(Inline)]
        public static bool operator ==(FieldIndexEntry<E,W> lhs, FieldIndexEntry<E,W> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(FieldIndexEntry<E,W> lhs, FieldIndexEntry<E,W> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal FieldIndexEntry(E index, string name, W width)
        {
            this.FieldIndex = index;
            this.FieldName = name;
            this.FieldWidth = width;
        }

        public string Format()
        {
            var t = typeof(E).Name;
            var i = Enums.scalar<E,byte>(FieldIndex);
            var w = Enums.scalar<W,byte>(FieldWidth);
            return $"{t}[{i}:{w}] = {FieldName}";           
        }
        
        [MethodImpl(Inline)]
        public bool Equals(FieldIndexEntry<E,W> other)
            => FieldIndex.Equals(other.FieldIndex) 
            && FieldWidth.Equals(other.FieldWidth)  
            && FieldName.Equals(other.FieldName);

        [MethodImpl(Inline)]
        public int CompareTo(FieldIndexEntry<E,W> other)
            => FieldIndex.CompareTo(other.FieldIndex);

        public override string ToString()
            => Format();
         
        public override int GetHashCode()
            => HashCode.Combine(FieldIndex,FieldWidth);

        public override bool Equals(object obj)
            => obj is FieldIndexEntry<E,W> x && Equals(x);
    }    
}