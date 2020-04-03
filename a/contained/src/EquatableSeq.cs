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
    
    using static Seed;

    public readonly struct EquatableSeq<T> : IEquatableSeq<EquatableSeq<T>,T>
    {    
        public IEnumerable<T> Content {get;}

        IEnumerable<T> Items 
        {
            [MethodImpl(Inline)]
            get => Items ?? new T[]{};
        }

        [MethodImpl(Inline)]
        public static EquatableSeq<T> Define(IEnumerable<T> src)
            => new EquatableSeq<T>(src);

        [MethodImpl(Inline)]
        public bool Equals(EquatableSeq<T> other)
            => false;

        [MethodImpl(Inline)]
        public EquatableSeq(IEnumerable<T> src)
        {
            this.Content = src;
        }        
    }
}