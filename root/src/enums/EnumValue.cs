//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    using static Root;

    public readonly struct EnumValue<E,V>
        where E : unmanaged, Enum
        where V : unmanaged
    {
        public readonly int Index;

        public readonly E Enum;

        public readonly V Value;

        [MethodImpl(Inline)]
        public static implicit operator EnumValue<E,V>((int i, E e, V v) src)
            => new EnumValue<E,V>(src.i, src.e,src.v);

        [MethodImpl(Inline)]
        internal EnumValue(int i, E e, V v)
        {
            this.Index = i;
            this.Enum = e;
            this.Value = v;    
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out int i, out E e, out V v)
        {
            i = Index;
            e = Enum;
            v = Value;
        }
    }

     public readonly struct EnumValues<E,V> : IEnumerable<EnumValue<E, V>>
        where E : unmanaged, Enum
        where V : unmanaged
    {
        readonly EnumValue<E,V>[] values;

        [MethodImpl(Inline)]
        public static implicit operator EnumValues<E,V>(EnumValue<E,V>[] src)
            => default;

        [MethodImpl(Inline)]
        public EnumValues(EnumValue<E,V>[] src) 
            => values = src;

        [MethodImpl(Inline)]
        public EnumValue<E,V>[] ToArray()
            => values;

        public int Length
        {
            [MethodImpl(Inline)]
            get => values.Length;
        }

        public ref readonly EnumValue<E,V> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref values[i];
        }
        
        public IEnumerator<EnumValue<E, V>> GetEnumerator()
            => ((IEnumerable<EnumValue<E, V>>)values).GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator()
            => values.GetEnumerator();

        public LiteralIndices<E> Indices
            => Enums.indices<E>();
    }
}