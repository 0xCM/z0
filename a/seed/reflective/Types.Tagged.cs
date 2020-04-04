//-------------------------------------------------------------------------------------------
// MetaCore
// Author: Chris Moore, 0xCM@gmail.com
// License: MIT
//-------------------------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    partial class XTend
    {
        /// <summary>
        /// Selects source types from the stream to wich a parametrically-identified attribute is applied
        /// </summary>
        /// <param name="src">The source stypes</param>
        /// <typeparam name="A">The attribute type</typeparam>
        public static IEnumerable<Type> Tagged<A>(this IEnumerable<Type> src)
            where A : Attribute
                => src.Where(t => t.Tagged<A>());
    }
}