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

    public static class StructOps
    {
        [MethodImpl(Inline)]
        public static bool IsNone<T>(this T? src)
            where T : struct
                => !src.HasValue;

        [MethodImpl(Inline)]
        public static bool IsSome<T>(this T? src)
            where T : struct
                => src.HasValue;

        [MethodImpl(Inline)]
        public static Y? TryMap<X,Y>(this X? x, Func<X,Y> f)
            where X : struct
            where Y : struct
                => x.HasValue ? f(x.Value) : (Y?)null;

        [MethodImpl(Inline)]
        public static Y Map<X,Y>(this X? x, Func<X,Y> f)
            where X : struct
            where Y : struct
                => x.HasValue ? f(x.Value) : default(Y);

        public static void OnSome<T>(this T? x, Action<T> f)
            where T : struct
        {
            if(x.HasValue)
                f(x.Value); 
        }

        public static void OnNone<T>(this T? x, Action f)
            where T : struct
        {
            if(!x.HasValue)
                f(); 
        }

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
    }
}