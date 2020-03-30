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
        public static SpanKind Kind(Type t)
            =>  t.GenericDefinition2() == typeof(Span<>) ? SpanKind.Mutable
              : t.GenericDefinition2() == typeof(ReadOnlySpan<>) ? SpanKind.Immutable
              : t.Tagged<CustomSpanAttribute>() ? SpanKind.Custom
              : 0;

        /// <summary>
        /// Determines whether a type is a span
        /// </summary>
        /// <param name="t">The type to examine</param>
        public static bool IsSpan(Type t)
            => Kind(t) != 0;    
        
        public static bool IsSystemSpan(SpanKind kind)
            => kind == Z0.SpanKind.Mutable || kind == Z0.SpanKind.Immutable;

        /// <summary>
        /// Tests whether a type defines a system-defined span
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool IsSystemSpan(Type t)
             => IsSystemSpan(Kind(t));

        /// <summary>
        /// Tests whether a type defines a system-defined span
        /// </summary>
        /// <param name="t">The type to test</param>
        public static bool IsCustomSpan(Type t)
             => Kind(t) == SpanKind.Custom;

    }
}