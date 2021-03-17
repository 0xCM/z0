//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct Parser<T> : IParseFunction<T>
    {
        readonly ParseFunction<T> F;

        [MethodImpl(Inline)]
        internal Parser(ParseFunction<T> f)
            => F = f;

        [MethodImpl(Inline)]
        public Outcome Parse(string src, out T dst)
            => F(src, out dst);
    }
}