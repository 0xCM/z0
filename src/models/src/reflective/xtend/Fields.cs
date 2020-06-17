//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Selects the static fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] Static(this FieldInfo[] src)
            => src.Where(x => x.IsStatic);

        /// <summary>
        /// Selects the instance fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] Instance(this FieldInfo[] src)
            => src.Where(x => !x.IsStatic);

        /// <summary>
        /// Selects the immutable fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] Immutable(this FieldInfo[] src)
            => src.Where(x => x.IsInitOnly || x.IsLiteral);

        /// <summary>
        /// Selects the mmutable fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] Mutable(this FieldInfo[] src)
            => src.Where(x => !(x.IsInitOnly || x.IsLiteral));

        /// <summary>
        /// Selects the public fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] Public(this FieldInfo[] src)
            => src.Where(x => x.IsPublic);

        /// <summary>
        /// Selects the non-public fields from a stream
        /// </summary>
        /// <param name="src">The source stream</param>
        public static FieldInfo[] NonPublic(this FieldInfo[] src)
            => src.Where(x => !x.IsPublic);

        /// <summary>
        /// Selects the fields from the stream for which the field type name contains the search string
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <param name="search">The search string</param>
        public static FieldInfo[] WithTypeNameLike(this FieldInfo[] src, string search)
            => src.Where(x => x.FieldType.Name.Contains(search));
    }
}