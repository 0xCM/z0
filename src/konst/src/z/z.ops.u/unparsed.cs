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
            => root.unparsed(source, target);

        [MethodImpl(Inline)]
        public static ParseResult<S,T> unparsed<S,T>(S source, T target, string reason)
            => root.unparsed<S,T>(source, target, reason);

        [MethodImpl(Inline)]
        public static ParseResult<string,T> unparsed<T>(string source, T target = default)
            => root.unparsed(source, target);

        [MethodImpl(Inline)]
        public static ParseResult<string,T> unparsed<T>(string source, Exception error, T target = default)
            => root.unparsed<T>(source, error, target);

        [MethodImpl(Inline)]
        public static ParseResult<string,T> unparsed<T>(string source, string reason)
            => root.unparsed<T>(source, reason);

        [MethodImpl(Inline)]
        public static ParseResult<T> unparsed<T>(char source, object reason = null)
            => root.unparsed<T>(source, reason);
    }
}