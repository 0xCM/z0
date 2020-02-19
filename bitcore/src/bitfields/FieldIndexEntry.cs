//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;         

    public readonly struct FieldIndexEntry : IFieldIndexEntry<FieldIndexEntry>
    {
        public int Index {get;}

        public string FieldName {get;}

        public Enum FieldValue {get;}

        [MethodImpl(Inline)]
        public static bool operator ==(FieldIndexEntry lhs, FieldIndexEntry rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(FieldIndexEntry lhs, FieldIndexEntry rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal FieldIndexEntry(int position, string name, Enum value)
        {
            this.Index = position;
            this.FieldName = name;
            this.FieldValue = value;
        }

        public string Format()
            => this.FormatEntry();

        [MethodImpl(Inline)]
        public bool Equals(FieldIndexEntry other)
            => Index == other.Index && FieldValue.Equals(other.FieldValue) && FieldName.Equals(other.FieldName);

        [MethodImpl(Inline)]
        public int CompareTo(FieldIndexEntry other)
            => Index.CompareTo(other.Index);
 
        public override string ToString()
            => Format();
           
        public override int GetHashCode()
            => HashCode.Combine(Index,FieldValue);

        public override bool Equals(object obj)
            => obj is FieldIndexEntry x && Equals(x);
    }

    /// <summary>
    /// Associates the declaration order of an enum literal with the corresponding literal value
    /// </summary>
    public readonly struct FieldIndexEntry<E> : IFieldIndexEntry<FieldIndexEntry<E>,E>
        where E : unmanaged, Enum
    {        
        public int Index {get;}

        public string FieldName {get;}

        public E FieldValue {get;}

        [MethodImpl(Inline)]
        public static implicit operator FieldIndexEntry(FieldIndexEntry<E> src)
            => new FieldIndexEntry(src.Index, src.FieldName, src.FieldValue);

        [MethodImpl(Inline)]
        public static bool operator ==(FieldIndexEntry<E> lhs, FieldIndexEntry<E> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(FieldIndexEntry<E> lhs, FieldIndexEntry<E> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal FieldIndexEntry(int index, string name, E value)
        {
            this.Index = index;
            this.FieldName = name;
            this.FieldValue = value;
        }

        public string Format()
            => this.FormatEntry();
        
        [MethodImpl(Inline)]
        public bool Equals(FieldIndexEntry<E> other)
            => Index == other.Index && FieldValue.Equals(other.FieldValue)  && FieldName.Equals(other.FieldName);

        [MethodImpl(Inline)]
        public int CompareTo(FieldIndexEntry<E> other)
            => Index.CompareTo(other.Index);

        public override string ToString()
            => Format();
         
        public override int GetHashCode()
            => HashCode.Combine(Index,FieldValue);

        public override bool Equals(object obj)
            => obj is FieldIndexEntry<E> x && Equals(x);
    }
}