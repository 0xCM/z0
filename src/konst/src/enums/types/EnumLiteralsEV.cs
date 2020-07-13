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

    using static Konst;

    /// <summary>
    /// Defines an E-V parametric literal index
    /// </summary>
     public readonly struct EnumLiterals<E,V> : IEnumerable<EnumLiteral<E,V>>, IConstIndex<EnumLiteral<E,V>>
        where E : unmanaged, Enum
        where V : unmanaged
    {
        readonly EnumLiteral<E,V>[] Data;

        [MethodImpl(Inline)]
        public static implicit operator EnumLiterals<E,V>(EnumLiteral<E,V>[] src)
            => new EnumLiterals<E,V>(src);

        [MethodImpl(Inline)]
        public EnumLiterals(EnumLiteral<E,V>[] src) 
            => Data = src;

        public int Length
        {
            [MethodImpl(Inline)]
            get => Data.Length;
        }

        public EnumLiteral<E,V>[] Content
        {
            [MethodImpl(Inline)]
            get => Data;
        }

        public ref readonly EnumLiteral<E,V> this[int i]
        {
            [MethodImpl(Inline)]
            get => ref Data[i];
        }
        
        public IEnumerator<EnumLiteral<E,V>> GetEnumerator()
            => ((IEnumerable<EnumLiteral<E,V>>)Data).GetEnumerator();
        
        IEnumerator IEnumerable.GetEnumerator()
            => Data.GetEnumerator();

        public EnumLiterals<E> Indices
            => Enums.index<E>();
    }
}