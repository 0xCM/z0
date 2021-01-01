//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct ClrQuery
    {
        [Op]
        public static ReadOnlySpan<ClrAssemblyName> references(Assembly src)
            => memory.recover<AssemblyName, ClrAssemblyName>(src.GetReferencedAssemblies().ToSpan());
    }
}