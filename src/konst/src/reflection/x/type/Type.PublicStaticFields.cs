//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static ReflectionFlags;

    partial class XReflex
    {
        public static FieldInfo[] PublicStaticFields(this Type src)
            => src.GetFields(BF_PublicStatic);

        /// <summary>
        /// Selects all public instance fields from the source
        /// </summary>
        /// <param name="src">The source type</param>
        public static FieldInfo[] PublicInstanceFields(this Type src)
            => src.GetFields(BF_PublicInstance);
    }
}