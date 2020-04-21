//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Control
    {
        /// <summary>
        /// Defines a valued option
        /// </summary>
        /// <param name="value">The value</param>
        /// <typeparam name="T">The type of the extant value</typeparam>
        [MethodImpl(Inline)]
        public static Option<T> some<T>(T value)
            => Option<T>.Some(value);

        /// <summary>
        /// Invokes an action if the supplied value is not null
        /// </summary>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="x">The potentially null value</param>
        /// <param name="f">The action to invoke if possible</param>
        [MethodImpl(Inline)]
        public static void ifsome<T>(T x, Action<T> f)
            where T : class
        {
            if(x != null)
                f(x);
        }

        /// <summary>
        /// Invokes an action if the supplied value is not null
        /// </summary>
        /// <typeparam name="V">The value type</typeparam>
        /// <param name="x">The potentially null value</param>
        /// <param name="f">The action to invoke if possible</param>
        [MethodImpl(Inline)]
        public static void ifsome<T>(T? x, Action<T> f)
            where T : struct
        {
            if(x.HasValue)
                f(x.Value);
        }
    }
}