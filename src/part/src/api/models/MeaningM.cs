//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [Datatype]
    public readonly struct Meaning<M> : IMeaning<Meaning<M>,M>
    {
        public M Content {get;}

        [MethodImpl(Inline)]
        public static Meaning<M> Attributed(Type src)
            => new Meaning<M>((M)MeaningAttribute.ContentValue(src));

        [MethodImpl(Inline)]
        public static implicit operator Meaning<M>(M src)
            => new Meaning<M>(src);

        [MethodImpl(Inline)]
        public Meaning(M src)
            => Content = src;

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0}", Content);
    }
}