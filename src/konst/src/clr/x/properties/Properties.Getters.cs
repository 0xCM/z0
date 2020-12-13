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
        [Op]
        public static MethodInfo[] Getters(this PropertyInfo[] src)
            => src.WithGet().Select(x => x.GetGetMethod());
    }
}