//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;
    using static ReflectionFlags;

    partial class XClrQuery
    {
        /// <summary>
        /// All of the methods belong to us
        /// </summary>
        /// <param name="src">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static MethodInfo[] WorldMethods(this Type src)
            => src.GetMethods(BF_World);
    }
}