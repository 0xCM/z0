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
    using System.Linq.Expressions;

    using static ReflectionFlags;
    
    partial class Reflective
    {
        /// <summary>
        /// Selects the static fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Static(this IEnumerable<FieldInfo> src)
            => src.Where(x => x.IsStatic);

        /// <summary>
        /// Selects the instance fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Instance(this IEnumerable<FieldInfo> src)
            => src.Where(x => !x.IsStatic);

        /// <summary>
        /// Selects the immutable fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Immutable(this IEnumerable<FieldInfo> src)
            => src.Where(x => x.IsInitOnly || x.IsLiteral);

        /// <summary>
        /// Selects the mmutable fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Mutable(this IEnumerable<FieldInfo> src)
            => src.Where(x => !(x.IsInitOnly || x.IsLiteral));

        /// <summary>
        /// Selects the public fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> Public(this IEnumerable<FieldInfo> src)
            => src.Where(x => x.IsPublic);

        /// <summary>
        /// Selects the non-public fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static IEnumerable<FieldInfo> NonPublic(this IEnumerable<FieldInfo> src)
            => src.Where(x => !x.IsPublic);

        /// <summary>
        /// Selects the fields from the stream for which the field type name contains the search string
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="search">The search string</param>
        public static IEnumerable<FieldInfo> WithTypeNameLike(this IEnumerable<FieldInfo> src, string search)
            => src.Where(x => x.FieldType.Name.Contains(search));
    }
}