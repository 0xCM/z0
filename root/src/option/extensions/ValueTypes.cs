//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class OptionX
    {
        /// <summary>
        /// Transforms a nulluble value into an optional value
        /// </summary>
        /// <typeparam name="T">The underlying value type</typeparam>
        /// <param name="x">The potential value</param>
        [MethodImpl(Inline)]
        public static Option<T> ValueOrNone<T>(this T? x)
            where T : struct
                => x != null ? x.Value : Option<T>.None();

        /// <summary>
        /// Extracts the encapsluated value if present; otherwise reutrns the underlying value type default
        /// </summary>
        /// <param name="x">The optional value</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T ValueOrDefault<T>(this Option<T?> x, T? @default = null)
            where T : struct 
                => x.ValueOrElse(() =>  @default ?? default(T)).Value;

        [MethodImpl(Inline)]
        public static T? ToNullable<T>(this Option<T> x) 
            where T : struct
                => x.IsSome() ? new T?(x.ValueOrDefault()) : (T?)null;

        public static void OnValue<T>(this T? x, Action<T> f)
            where T : struct
                => onTrue(x.HasValue, () => f(x.Value));
    }
}