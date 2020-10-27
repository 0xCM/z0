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

    partial class XReflex
    {
        /// <summary>
        /// Selects the methods that are adorned with parametrically-identified attribute
        /// </summary>
        /// <param name="src">The methods to examine</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static MethodInfo[] Tagged<A>(this MethodInfo[] src)
            where A : Attribute
                => src.Where(m => m.Tagged<A>());

    }
}