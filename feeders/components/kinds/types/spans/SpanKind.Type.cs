//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public static class SpanTypes
    {
        /// <summary>
        /// Classifies a type according to whether it is a span, a readonly span, or otherwise
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static SpanKind kind(Type t)
            =>  t.GenericDefinition2() == typeof(Span<>) ? Z0.SpanKind.Mutable
              : t.GenericDefinition2() == typeof(ReadOnlySpan<>) ? Z0.SpanKind.Immutable
              : 0;

        /// <summary>
        /// Determines whether a type is parametric over the natural numbers
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool test(Type t)
            => kind(t) != 0;    
    }
}