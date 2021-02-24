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
    public readonly partial struct Outcomes
    {
        const NumericKind Closure = UnsignedInts;

        /// <summary>
        /// Creates an undesirable computation outcome
        /// </summary>
        /// <param name="e">The exception that caused the outcome to achieve an undesirable state</param>
        /// <param name="data">A payload value, if any</param>
        /// <typeparam name="T">The result payload type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Outcome<T> fail<T>(string message)
            => new Outcome<T>(false, default(T), message);

        /// <summary>
        /// Defines an outcome spec
        /// </summary>
        /// <param name="ok">Specifies whether the operation succeeded</param>
        /// <param name="data">The operation data</param>
        /// <typeparam name="T">The operation data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Outcome<T> define<T>(bool ok, T data, string message = EmptyString)
            => new Outcome<T>(ok, data, message);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Outcome<T> success<T>(T data, string message = EmptyString)
            => new Outcome<T>(true, data, message);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Outcome<T> fail<T>()
            => new Outcome<T>(false);
    }
}