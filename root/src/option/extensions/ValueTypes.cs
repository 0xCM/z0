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
        public static Y? TryMap<X,Y>(this X? x, Func<X,Y> f)
            where X : struct
            where Y : struct
                => x.HasValue ? f(x.Value) : (Y?)null;

        public static Y Map<X,Y>(this X? x, Func<X,Y> f)
            where X : struct
            where Y : struct
                => x.HasValue ? f(x.Value) : default(Y);

        public static bool IsSome<T>(this T? x, Action<T> f)
            where T : struct
                => x.HasValue;

        public static bool IsNone<T>(this T? x, Action<T> f)
            where T : struct
                => !x.HasValue; 

        [MethodImpl(Inline)]
        public static T ValueOrElse<T>(this T? x,  Func<T> @else)
            where T : struct
                => x != null ? x.Value : @else();

        [MethodImpl(Inline)]
        public static T ValueOrElse<T>(this T? x, T @else)
            where T : struct
                => x != null ? x.Value : @else;

        [MethodImpl(Inline)]
        public static S MapValueOrDefault<T, S>(this T? x, Func<T, S> f, S @default = default(S))
            where T : struct
                => x != null ? f(x.Value) : @default;

        [MethodImpl(Inline)]
        public static S? TryMapValue<T, S>(this T? x, Func<T, S> f)
            where T : struct
            where S : struct
                => x != null ? f(x.Value) : (S?)null;

        [MethodImpl(Inline)]
        public static S Map<T, S>(this T? x, Func<T, S> ifSome, Func<S> ifNone)
            where T : struct
                    => x != null ? ifSome(x.Value) : ifNone();

        [MethodImpl(Inline)]
        public static S MapValueOrElse<T, S>(this T? x, Func<T, S> f, Func<S> @else)
            where T : struct
                => x != null ? f(x.Value) : @else();

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