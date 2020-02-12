//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;
    using static SpanKind;

    public static class TypeKindX
    {

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static SpanKind SpanKind(this Type t)
            => t.GenericDefinition() == typeof(Span<>) ? Mutable
              : t.GenericDefinition() == typeof(ReadOnlySpan<>) ? Immutable
              : 0;

        [MethodImpl(Inline)]
        public static bool IsSome(this SpanKind kind)
            => kind != Z0.SpanKind.None;

        [MethodImpl(Inline)]
        public static T MapSomeOrElse<T>(this SpanKind kind, Func<SpanKind,T> ifSome, Func<T> ifNone)
            => kind.IsSome() ? ifSome(kind) : ifNone();

        [MethodImpl(Inline)]
        public static Option<(SpanKind kind, Type celltype)> SpanInfo(this Type arg)
            => arg.SpanKind().MapSomeOrElse(
                  k => (k, arg.GetGenericArguments().Single()), 
                 () => none<(SpanKind, Type)>());

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSpan(this Type t)
            => t.SpanKind().IsSome();

    }
}