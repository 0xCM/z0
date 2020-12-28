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
        public static AssemblyName[] ReferenceNames(this Assembly src)
            => src.GetReferencedAssemblies();

        [Op]
        public static Assembly[] References(this Assembly src)
            => src.ReferenceNames().Select(a => Assembly.Load(a));
    }
}