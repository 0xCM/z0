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
        readonly EnumLiteral<E>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator EnumLiterals<E>(EnumLiteral<E>[] src)
            => new EnumLiterals<E>(src);
        
        [MethodImpl(Inline)]
        internal EnumLiterals(EnumLiteral<E>[] src) 
            => Data = src;

        [MethodImpl(Inline)]
        public EnumLiteral<E>[] ToArray()
            => Data;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }
        
        public ref readonly EnumLiteral<E> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }
        
        public E[] Values => Data.Map(x => x.Value);

        public F[] Convert<F>()
            where F : unmanaged, Enum
        {
            var src = Values;
            var dst = new F[src.Length];

            for(var i=0; i< src.Length; i++)
                dst[i] = (F)(object)src[i];
            return dst;
        }
                
        public IEnumerable<NamedValue<E>> NamedValues
            => from i in Data select NamedValue.define(i.Name, i.Value);

        public IEnumerator<EnumLiteral<E>> GetEnumerator()
            => ((IEnumerable<EnumLiteral<E>>)Data).GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
            => Data.GetEnumerator();
    }
}