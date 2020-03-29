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
    
    partial class XTend
    {
        /// <summary>
        /// Returns all interfaces realized by the type, including those inherited from
        /// supertypes
        /// </summary>
        /// <param name="src">The type to examine</param>
        public static IEnumerable<Type> Interfaces(this Type src)
            => src.GetInterfaces() ?? new Type[]{};
    }
}