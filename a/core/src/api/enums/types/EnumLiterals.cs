//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    using System.Collections;

    using static Seed;

    public readonly struct EnumLiterals<E> : IEnumerable<EnumLiteral<E>>
        where E : unmanaged, Enum        
    {
        readonly EnumLiteral<E>[] indices;

        [MethodImpl(Inline)]
        public static implicit operator EnumLiterals<E>(EnumLiteral<E>[] src)
            => new EnumLiterals<E>(src);
        
        [MethodImpl(Inline)]
        internal EnumLiterals(EnumLiteral<E>[] src) 
            => indices = src;

        [MethodImpl(Inline)]
        public EnumLiteral<E>[] ToArray()
            => indices;

        public int Length
        {
            [MethodImpl(Inline)]
            get => indices.Length;
        }
        
        public ref readonly EnumLiteral<E> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref indices[i];
        }
        
        public IEnumerable<NamedValue<E>> NamedValues
            => from i in indices
                select NamedValue.Define(i.Name, i.Value);

        public IEnumerator<EnumLiteral<E>> GetEnumerator()
            => ((IEnumerable<EnumLiteral<E>>)indices).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => indices.GetEnumerator();
    }
}