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
    using static GenericKind;
    using static SpanKind;

    public static class TypeKindX
    {
        /// <summary>
        /// If type is a vector, determines its classification, otherwise returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static VectorKind VectorKind(this Type t)
            => VectorType.kind(t);

        /// <summary>
        /// If type is blocked, determines its classification, otherwise returns none
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static BlockKind BlockKind(this Type t)
            => BlockedType.kind(t);

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

        [MethodImpl(Inline)]
        public static GenericKind GenericKind(this Type src, bool effective)
            =>   src.IsOpenGeneric(false) ? Open 
               : src.IsClosedGeneric(false) ? Closed 
               : src.IsGenericTypeDefinition ? Definition 
               : 0;

        [MethodImpl(Inline)]
        public static GenericKind GenericKind(this MethodInfo src, bool effective)
            =>   src.IsOpenGeneric() ? Open 
               : src.IsClosedGeneric() ? Closed 
               : src.IsGenericMethodDefinition ? Definition 
               : 0;
    }
}