//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Parser<T,K> : IParseFunction<T,K>
        where K : unmanaged
    {
        readonly ParseFunction<T> F;

        public K Kind {get;}

        [MethodImpl(Inline)]
        public Parser(ParseFunction<T> f, K kind)
        {
            F = f;
            Kind = kind;
        }

        [MethodImpl(Inline)]
        public Outcome Parse(string src, out T dst)
            => F(src, out dst);
    }
}