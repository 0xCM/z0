//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Linq;

    partial class XClrQuery
    {

        /// <summary>
        /// Selects the public/non-public static/instance methods declared by a stream of types
        /// </summary>
        /// <param name="src">The types to examine</param>
        public static MethodInfo[] DeclaredMethods(this Type[] src)
            => src.Select(x => x.DeclaredMethods()).SelectMany(x => x);
    }
}