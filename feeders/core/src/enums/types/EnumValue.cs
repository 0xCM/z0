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

    using static Core;

    public readonly struct EnumValue
    {
        public static EnumValue<E,V> Define<E,V>(EnumLiteral<E> literal, V value)
            where E : unmanaged, Enum
            where V : unmanaged
                => new EnumValue<E,V>(literal,value);
    }

    public readonly struct EnumValue<E,V>
        where E : unmanaged, Enum
        where V : unmanaged
    {
        
        readonly EnumLiteral<E> Literal;

        public readonly V NumericValue;

        public E LiteralValue => Literal.Value;

        public int Index => Literal.Index;

        [MethodImpl(Inline)]
        internal EnumValue(EnumLiteral<E> literal, V v)
        {
            this.Literal = literal;
            this.NumericValue = v;    
        }

        [MethodImpl(Inline)]
        public void Deconstruct(out int i, out E e, out V v)
        {
            i = Index;
            e = LiteralValue;
            v = NumericValue;
        }
    }

     public readonly struct EnumValues<E,V> : IEnumerable<EnumValue<E, V>>
        where E : unmanaged, Enum
        where V : unmanaged
    {
        readonly EnumValue<E,V>[] values;

        [MethodImpl(Inline)]
        public static implicit operator EnumValues<E,V>(EnumValue<E,V>[] src)
            => new EnumValues<E,V>(src);

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

        public EnumLiterals<E> Indices
            => Enums.literals<E>();
    }
}