//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static zfunc;

    public enum SpanKind
    {
        None = 0,

        Mutable = 1,

        Immutable = 2
    }

    partial class FastOpX
    {
    
        [MethodImpl(Inline)]
        public static bool IsSome(this SpanKind kind)
            => kind != Z0.SpanKind.None;

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static SpanKind SpanKind(this Type t)
            => t.GenericDefinition() == typeof(Span<>) ? Z0.SpanKind.Mutable
              : t.GenericDefinition() == typeof(ReadOnlySpan<>) ? Z0.SpanKind.Immutable
              : Z0.SpanKind.None;

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline)]
        public static bool IsSpan(this Type t)
            => t.SpanKind().IsSome();

        public static Option<(SpanKind kind, Type celltype)> SpanInfo(this Type arg)
        {
            var kind = arg.SpanKind();
            if(kind.IsSome())
                return(kind, arg.GetGenericArguments().Single());
            else
                return none<(SpanKind kind, Type celltype)>();

        }

    }
}