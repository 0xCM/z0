//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    /// <summary>
    /// Associates the declaration order of an enum literal with the corresponding literal value
    /// </summary>
    public readonly struct BitFieldIndexEntry<E,W> : IBitFieldIndexEntry<BitFieldIndexEntry<E,W>,E,W>
        where E : unmanaged
        where W : unmanaged
    {
        public E FieldIndex {get;}

        public string FieldName {get;}

        public W FieldWidth {get;}

        [MethodImpl(Inline)]
        internal BitFieldIndexEntry(E index, string name, W width)
        {
            FieldIndex = index;
            FieldName = name;
            FieldWidth = width;
        }

        public string Format()
        {
            var t = typeof(E).Name;
            var i = @as<E,byte>(FieldIndex);
            var w = @as<W,byte>(FieldWidth);
            return $"{t}[{i}:{w}] = {FieldName}";
        }

        [MethodImpl(Inline)]
        public bool Equals(BitFieldIndexEntry<E,W> other)
            => FieldIndex.Equals(other.FieldIndex)
            && FieldWidth.Equals(other.FieldWidth)
            && FieldName.Equals(other.FieldName);

        [MethodImpl(Inline)]
        public int CompareTo(BitFieldIndexEntry<E,W> other)
            => @as<E,uint>(FieldIndex).CompareTo(@as<E,uint>(other.FieldIndex));

        public override string ToString()
            => Format();

        public override int GetHashCode()
            => HashCode.Combine(FieldIndex,FieldWidth);

        public override bool Equals(object obj)
            => obj is BitFieldIndexEntry<E,W> x && Equals(x);

        [MethodImpl(Inline)]
        public static bool operator ==(BitFieldIndexEntry<E,W> lhs, BitFieldIndexEntry<E,W> rhs)
            => lhs.Equals(rhs);

        [MethodImpl(Inline)]
        public static bool operator !=(BitFieldIndexEntry<E,W> lhs, BitFieldIndexEntry<E,W> rhs)
            => !lhs.Equals(rhs);
    }
}