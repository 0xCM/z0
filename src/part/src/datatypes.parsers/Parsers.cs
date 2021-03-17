//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct Parsers
    {
        const NumericKind Closure = AllNumeric;

        [Op]
        public static ParseFunctions functions(params IParseFunction[] src)
            => new ParseFunctions(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Parser<T> create<T>(ParseFunction<T> f)
            => new Parser<T>(f);

        [MethodImpl(Inline)]
        public static Parser<T,K> create<T,K>(ParseFunction<T> f, K kind)
            where K : unmanaged
                => new Parser<T,K>(f,kind);
    }
}