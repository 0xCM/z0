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
        public static Type[] NonPublicTypes(this Assembly a)
            => a.Types().NonPublic();
    }
}