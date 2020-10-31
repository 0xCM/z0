//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    partial class XClrQuery
    {
        /// <summary>
        /// Selects the properties with both get/set methods from the stream
        /// </summary>
        /// <param name="src">The properties to examine</param>
        [Op]
        public static PropertyInfo[] WithGetAndSet(this PropertyInfo[] src)
            => src.Where(p => p.GetGetMethod() != null && p.GetSetMethod() != null);
    }
}