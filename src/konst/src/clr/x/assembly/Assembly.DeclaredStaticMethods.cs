//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class XClrQuery
    {
        [Op]
        public static MethodInfo[] DeclaredStaticMethods(this Assembly src)
            => src.Types().DeclaredStaticMethods();
    }
}