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
        /// Selects the property type from each source property
        /// </summary>
        /// <param name="src">The source properties</param>
        public static Type[] PropertyTypes(this PropertyInfo[] src)
            => src.Select(x => x.PropertyType);
    }
}