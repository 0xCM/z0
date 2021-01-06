//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class ClrQuery
    {
        /// <summary>
        /// Determines whether the property has both a public getter and setter
        /// </summary>
        /// <param name="p">The property to examine</param>
         [MethodImpl(Inline), Op]
         public static bool HasPublicGetterAndSetter(this PropertyInfo p)
            => p.HasPublicGetter() && p.HasPublicSetter();
    }
}