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
        [MethodImpl(Inline), Op]
        public static Type[] Types(this Assembly a)
            => a.GetTypes();
    }
}