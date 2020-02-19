//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static zfunc;

    /// <summary>
    /// Associates the declaration order of an enum literal with the corresponding literal value
    /// </summary>
    public readonly struct EnumIndexEntry<E> : IFormattable<EnumIndexEntry<E>>, IEquatable<EnumIndexEntry<E>>, IComparable<EnumIndexEntry<E>>
        where E : unmanaged, Enum
    {        
        public readonly int Position;

        public readonly E Value;

        public readonly string Name;

        [MethodImpl(Inline)]
        public static bool operator ==(EnumIndexEntry<E> lhs, EnumIndexEntry<E> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(EnumIndexEntry<E> lhs, EnumIndexEntry<E> rhs)
            => !lhs.Equals(rhs);

        [MethodImpl(Inline)]
        internal EnumIndexEntry(int index, string name, E value)
        {
            this.Position = index;
            this.Name = name;
            this.Value = value;
        }

        public string Format()
            => $"{typeof(E).Name}[{Position}] = {Name}";
        
        [MethodImpl(Inline)]
        public bool Equals(EnumIndexEntry<E> other)
            => Position == other.Position && Value.Equals(other.Value);

        [MethodImpl(Inline)]
        public int CompareTo(EnumIndexEntry<E> other)
            => Position.CompareTo(other.Position);

        public override string ToString()
            => Format();
         
        public override int GetHashCode()
            => HashCode.Combine(Position,Value);

        public override bool Equals(object obj)
            => obj is EnumIndexEntry<E> x && Equals(x);
    }
}