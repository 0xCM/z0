//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    

    public readonly struct FieldIndexEntry : IFieldIndexEntry<FieldIndexEntry>
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
        public static bool operator ==(FieldIndexEntry lhs, FieldIndexEntry rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(FieldIndexEntry lhs, FieldIndexEntry rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal FieldIndexEntry(int index, string name, Enum width)
        {
            this.FieldIndex = index;
            this.FieldName = name;
            this.FieldWidth = width;
        }

        public string Format()
            => this.FormatEntry();

        [MethodImpl(Inline)]
        public bool Equals(FieldIndexEntry other)
            => FieldIndex == other.FieldIndex && FieldWidth.Equals(other.FieldWidth) && FieldName.Equals(other.FieldName);

        [MethodImpl(Inline)]
        public int CompareTo(FieldIndexEntry other)
            => FieldIndex.CompareTo(other.FieldIndex);
 
        public override string ToString()
            => Format();
           
        public override int GetHashCode()
            => HashCode.Combine(FieldIndex,FieldWidth);

        public override bool Equals(object obj)
            => obj is FieldIndexEntry x && Equals(x);
    }

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
            => this.FormatEntry();
        
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

    /// <summary>
    /// Associates the declaration order of an enum literal with the corresponding literal value
    /// </summary>
    public readonly struct FieldIndexEntry<I,W> : IFieldIndexEntry<FieldIndexEntry<I,W>,I,W>
        where I : unmanaged, Enum
        where W : unmanaged, Enum
    {        
        public I FieldIndex {get;}

        public string FieldName {get;}

        public W FieldWidth {get;}

        [MethodImpl(Inline)]
        public static bool operator ==(FieldIndexEntry<I,W> lhs, FieldIndexEntry<I,W> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(FieldIndexEntry<I,W> lhs, FieldIndexEntry<I,W> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal FieldIndexEntry(I index, string name, W width)
        {
            this.FieldIndex = index;
            this.FieldName = name;
            this.FieldWidth = width;
        }

        public string Format()
        {
            var t = typeof(I).Name;
            var i = Enums.numeric<I,byte>(FieldIndex);
            var w = Enums.numeric<W,byte>(FieldWidth);
            return $"{t}[{i}:{w}] = {FieldName}";           
        }
        
        [MethodImpl(Inline)]
        public bool Equals(FieldIndexEntry<I,W> other)
            => FieldIndex.Equals(other.FieldIndex) 
            && FieldWidth.Equals(other.FieldWidth)  
            && FieldName.Equals(other.FieldName);

        [MethodImpl(Inline)]
        public int CompareTo(FieldIndexEntry<I,W> other)
            => FieldIndex.CompareTo(other.FieldIndex);

        public override string ToString()
            => Format();
         
        public override int GetHashCode()
            => HashCode.Combine(FieldIndex,FieldWidth);

        public override bool Equals(object obj)
            => obj is FieldIndexEntry<I,W> x && Equals(x);
    }    
}