//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    partial class XClrQuery
    {
        [Op]
        public static Type[] Interfaces(this Assembly a)
            => a.Types().Interfaces();
    }
}