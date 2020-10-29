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
        /// Selects the static properties from an array
        /// </summary>
        /// <param name="src">The source array</param>
        [Op]
        public static PropertyInfo[] Static(this PropertyInfo[] src)
            => src.Where(p => p.IsStatic());
    }
}