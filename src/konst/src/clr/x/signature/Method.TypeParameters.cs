//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial class XClrQuery
    {
        /// <summary>
        /// Describes a method's type parameters, if any
        /// </summary>
        /// <param name="method">The method to examine</param>
        [Op]
        public static ClrTypeParamInfo[] TypeParameters(this MethodInfo method)
            => method.GenericParameters(false).Mapi((i,t) => new ClrTypeParamInfo(t.DisplayName(), i));
    }
}