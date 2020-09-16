//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct Outcomes
    {
        /// <summary>
        /// Defines an outcome spec
        /// </summary>
        /// <param name="ok">Specifies whether the operation succeeded</param>
        /// <param name="data">The operation data</param>
        /// <typeparam name="T">The operation data type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Outcome<T> outcome<T>(bool ok, T data)
            => new Outcome<T>(ok,data);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Outcome<T> fail<T>(T data = default)
            => new Outcome<T>(false, data);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Outcome<T> success<T>(T data)
            => new Outcome<T>(true, data);

        [MethodImpl(Inline)]
        public static Outcome<A,B> success<A,B>(Outcome<B> src, A data)
            => new Outcome<A,B>(true, data, src.Data);

        [MethodImpl(Inline)]
        public static Outcome<A,B> fail<A,B>(Outcome<B> src, A data = default)
            => new Outcome<A,B>(false, data, src.Data);

        [MethodImpl(Inline)]
        public static Outcome<D,E> outcome<D,E>(bool success, D data, E error)
            => new Outcome<D,E>(success, data, error);

        [MethodImpl(Inline)]
        public static Outcome<D,E> success<D,E>(D data, E error = default)
            => outcome(true, data, error);

        [MethodImpl(Inline)]
        public static Outcome<D,E> fail<D,E>(E error, D data = default)
            => outcome(false, data, error);
    }
}