//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static ReflectionFlags;

    partial class XClrQuery
    {
        /// <summary>
        /// Retrieves the public and non-public instance methods declared by a type
        /// </summary>
        /// <param name="t">The type to examine</param>
        [MethodImpl(Inline), Op]
        public static MethodInfo[] InstanceMethods(this Type src)
            => src.GetMethods(BF_World);
    }
}