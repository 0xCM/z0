//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ParseResult<S,T> unparsed<S,T>(S source, T target = default)
            => zfunc.unparsed(source, target);

        [MethodImpl(Inline)]
        public static ParseResult<S,T> unparsed<S,T>(S source, T target, string reason)
            => zfunc.unparsed<S,T>(source, target, reason);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ParseResult<string,T> unparsed<T>(string source, T target = default)
            => zfunc.unparsed(source, target);

        [MethodImpl(Inline)]
        public static ParseResult<string,T> unparsed<T>(string source, Exception error, T target = default)
            => zfunc.unparsed<T>(source, error, target);

        [MethodImpl(Inline)]
        public static ParseResult<string,T> unparsed<T>(string source, string reason)
            => zfunc.unparsed<T>(source, reason);

        [MethodImpl(Inline)]
        public static ParseResult<T> unparsed<T>(char source, object reason = null)
            => zfunc.unparsed<T>(source, reason);
    }
}