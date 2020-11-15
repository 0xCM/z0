//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Meaning<M,T> : IMeaning<Meaning<M,T>,M,T>
    {
        public M Content {get;}

        public T Target {get;}

        [MethodImpl(Inline)]
        public static Meaning<M,T> attributed(Type src)
        {
            (var c, var t) = MeaningAttribute.ContentTarget(src);
            return new Meaning<M,T>((M)c, (T)t);
        }

        [MethodImpl(Inline)]
        public static implicit operator Meaning<M,T>((M src,T dst) x)
            => new Meaning<M,T>(x.src, x.dst);

        [MethodImpl(Inline)]
        public Meaning(M src, T dst)
        {
            Content = src;
            Target = dst;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format("{0} -> {1}", Content, Target);
    }
}