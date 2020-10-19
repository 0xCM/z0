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
        /// <summary>
        /// Defines an outcome spec
        /// </summary>
        /// <param name="ok">Specifies whether the operation succeeded</param>
        /// <param name="data">The operation data</param>
        /// <typeparam name="T">The operation data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Outcome<T> outcome<T>(bool ok, T data)
            => new Outcome<T>(ok,data);

        [MethodImpl(Inline)]
        public static Outcome<D,E> outcome<D,E>(bool success, D data, E error)
            => new Outcome<D,E>(success, data, error);
    }
}