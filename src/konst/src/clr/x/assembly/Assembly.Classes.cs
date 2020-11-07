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
        public static Type[] Classes(this Assembly a)
            => a.Types().Classes();

        [Op]
        public static Type[] Classes(this Assembly a, string name)
            => a.Classes().Where(c => c.Name == name);
    }
}