//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    
    partial class XTend
    {
        /// <summary>
        /// Determines whether the property has a public setter
        /// </summary>
        /// <param name="p">The property to examine</param>
        public static bool HasPublicSetter(this PropertyInfo p)
            => p.GetSetMethod() != null;            
    }
}