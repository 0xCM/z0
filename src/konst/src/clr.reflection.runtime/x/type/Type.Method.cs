//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XReflex
    {
        /// <summary>
        /// Selects the first method found on the type, if any, that has a specified name
        /// </summary>
        /// <param name="src">The type to examine</param>
        /// <param name="name">The name to match</param>
        [Op]
        public static MethodInfo Method(this Type src, string name)
            => src.DeclaredMethods().WithName(name).First();
    }
}