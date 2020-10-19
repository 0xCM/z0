//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Eval
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Outcome<T> success<T>(T data)
            => new Outcome<T>(true, data);

        [MethodImpl(Inline)]
        public static Outcome<A,B> success<A,B>(Outcome<B> src, A data)
            => new Outcome<A,B>(true, data, src.Data);

        [MethodImpl(Inline)]
        public static Outcome<D,E> success<D,E>(D data, E error = default)
            => outcome(true, data, error);
    }
}
