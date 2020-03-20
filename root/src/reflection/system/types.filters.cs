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

    using static ReflectionFlags;

    partial class RootReflections
    {
        /// <summary>
        /// Selects source types from the stream to wich a parametrically-identified attribute is applied
        /// </summary>
        /// <param name="src">The source stypes</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static IEnumerable<Type> Tagged<A>(this IEnumerable<Type> src)
            where A : Attribute
                => src.Where(t => System.Attribute.IsDefined(t, typeof(A)));


    }
}