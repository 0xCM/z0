//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static ReflectionFlags;
    using static Konst;

    partial class XClrQuery
    {
        /// <summary>
        /// Queries the source <see cref='Type'/> for the <see cref='FieldInfo'/> members determined by the <see cref='BF_All'/> flags
        /// </summary>
        /// <param name="src">The source type</param>
        [MethodImpl(Inline), Op]
        public static FieldInfo[] Fields(this Type src)
            => src.GetFields(BF_All);
    }
}