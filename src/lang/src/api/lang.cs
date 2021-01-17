//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct lang
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static Keyword keyword(string name)
            => new Keyword(name);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe Keyword<A> keyword<A>(Keyword @base, A a0)
            => new Keyword<A>(@base.Address, a0);
    }
}