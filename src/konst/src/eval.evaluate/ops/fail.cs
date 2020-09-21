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
        public static Outcome<T> fail<T>(T data = default)
            => new Outcome<T>(false, data);

        [MethodImpl(Inline)]
        public static Outcome<A,B> fail<A,B>(Outcome<B> src, A data = default)
            => new Outcome<A,B>(false, data, src.Data);

        [MethodImpl(Inline)]
        public static Outcome<D,E> fail<D,E>(E error, D data = default)
            => outcome(false, data, error);
    }
}