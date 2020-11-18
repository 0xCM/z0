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
        [Op, MethodImpl(Inline)]
        public static bool IsConcrete(this MethodInfo src)
            => !src.IsAbstract && !src.ContainsGenericParameters;
    }
}