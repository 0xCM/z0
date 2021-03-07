//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    partial class ClrQuery
    {
        [Op]
        public static Type[] PublicTypes(this Assembly a)
            => a.Types().Public();
    }
}