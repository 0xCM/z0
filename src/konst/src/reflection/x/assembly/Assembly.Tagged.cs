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

    partial class XReflex
    {
        /// <summary>
        /// Determines whether an assembly has an attribute of a given type
        /// </summary>
        /// <param name="a">The source assembly</param>
        /// <typeparam name="T">The attribute type</typeparam>
        public static bool Tagged<T>(this Assembly a)
            where T : Attribute
                => System.Attribute.IsDefined(a, typeof(T));
    }
}