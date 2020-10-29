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
        /// Selects the source properties with property types that match one of the types in a caller-supplied parameter array
        /// </summary>
        /// <param name="src">The properties to filter</param>
        /// <param name="match">The property type match target</param>
        [Op]
        public static PropertyInfo[] WithPropertyType(this PropertyInfo[] src, params Type[] match)
            => src.Where(p => match.Contains(p.PropertyType));
    }
}