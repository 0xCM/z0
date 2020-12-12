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

    partial class XClrQuery
    {
        [MethodImpl(Inline), Op]
        public static bool IsStatic(this PropertyInfo p)
            => p.GetGetMethod()?.IsStatic == true
            || p.GetSetMethod()?.IsStatic == true;
    }
}