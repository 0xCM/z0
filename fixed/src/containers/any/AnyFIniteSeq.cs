//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;
    
    using static Root;

    public readonly struct AnyFiniteSeq<T> : IAnyFiniteSeq<AnyFiniteSeq<T>,T>
    {    
        public T[] Content {get;}

        T[] content
        {
            [MethodImpl(Inline)]
            get => content ?? array<T>();
        }

        [MethodImpl(Inline)]
        public static AnyFiniteSeq<T> Define(IEnumerable<T> src)
            => new AnyFiniteSeq<T>(src?.ToArray() ?? array<T>());


        [MethodImpl(Inline)]
        public static AnyFiniteSeq<T> Define(T[] src)
            => new AnyFiniteSeq<T>(src ?? array<T>());

        [MethodImpl(Inline)]
        public bool Equals(AnyFiniteSeq<T> other)
            => false;

        [MethodImpl(Inline)]
        public AnyFiniteSeq(T[] src)
        {
            this.Content = src ?? array<T>();
        }

        public AnyFiniteSeqFactory<T,AnyFiniteSeq<T>> Factory
             => Define; 
    }
}