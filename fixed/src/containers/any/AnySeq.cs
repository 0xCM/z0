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

    public readonly struct AnySeq<T> : IAnySeq<AnySeq<T>,T>
    {    
        public IEnumerable<T> Content {get;}

        IEnumerable<T> Items 
        {
            [MethodImpl(Inline)]
            get => Items ?? array<T>();
        }

        [MethodImpl(Inline)]
        public static AnySeq<T> Define(IEnumerable<T> src)
            => new AnySeq<T>(src);

        [MethodImpl(Inline)]
        public bool Equals(AnySeq<T> other)
            => false;

        [MethodImpl(Inline)]
        public AnySeq(IEnumerable<T> src)
        {
            this.Content = src;
        }


        public AnySeqFactory<T,AnySeq<T>> Factory
             => Define;
 
        string ICustomFormattable.Format()
            => text.concat(Items.TakeAtMost(20), text.comma());
    }
}