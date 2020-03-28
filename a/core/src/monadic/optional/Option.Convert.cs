//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;
    using static Option;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static Option<T> ToOption<T>(this T? src)
            where T : struct
                =>  src.HasValue ? src.Value : Option.none<T>();

        [MethodImpl(Inline)]
        public static T? ToNullable<T>(this Option<T> x) 
            where T : struct
                => x.IsSome() ? new T?(x.ValueOrDefault()) : (T?)null;

        /// <summary>
        /// Lifts a type value to an option that is valued iff the source type is non-void
        /// </summary>
        /// <param name="src">The value to lift</param>
        [MethodImpl(Inline)]
        public static Option<Type> ToOption(this Type src)
            => src == typeof(void) ? none<Type>() : some(src);
    }
}