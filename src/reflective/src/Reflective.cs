//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    
    [ApiHost]
    public static partial class Reflective
    {
        /// <summary>
        /// The empty type
        /// </summary>
        public static Type TEmpty => typeof(void);

        /// <summary>
        /// Returns true if the source type is non-null and non-void; otherwise, returns false
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static bool IsSome(this Type src)
            => src != null && src != typeof(void);

        internal const MethodImplOptions Inline = MethodImplOptions.AggressiveInlining;

        [MethodImpl(Inline)]
        internal static IEnumerable<T> seq<T>(params T[] src)
            => src;

        [MethodImpl(Inline)]
        internal static T[] array<T>(params T[] src)
            => src;

        /// <summary>
        /// Encloses text between less than and greater than characters
        /// </summary>
        /// <param name="content">The content to enclose</param>
        [MethodImpl(Inline)]
        internal static string angled(string content)
            => String.IsNullOrWhiteSpace(content) ? string.Empty : $"<{content}>";
    }

    public static partial class XTend
    {

    }

}