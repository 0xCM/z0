//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static ReflectionFlags;
    
    partial class XTend
    {
        /// <summary>
        /// Selects all instance/static and public/non-public fields declared or inherited by a type
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static FieldInfo[] Fields(this Type src)
            => src.GetFields(BF_All);

        /// <summary>
        /// Selects all public static/instance fields from the source
        /// </summary>
        /// <param name="src">The source type</param>
        public static FieldInfo[] PublicFields(this Type src)
            => src.GetFields(BF_AllPublicStatic | BF_AllPublicInstance);

        /// <summary>
        /// Selects all public instance fields from the source
        /// </summary>
        /// <param name="src">The source type</param>
        public static FieldInfo[] PublicInstanceFields(this Type src)
            => src.GetFields(BF_AllPublicInstance);

        public static FieldInfo[] PublicStaticFields(this Type src)
            => src.GetFields(BF_AllPublicStatic);

        /// <summary>
        /// Retrieves the public instance Fields declared by a supertype
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static FieldInfo[] InheritedPublicFields(this Type src)
            => src.BaseType?.GetFields(BF_AllPublicInstance) ?? new FieldInfo[] { };
    }
}