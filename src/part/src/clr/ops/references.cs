//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    partial struct Clr
    {
        [Op]
        public static ReadOnlySpan<ClrAssemblyName> references(Assembly src)
            => memory.recover<AssemblyName, ClrAssemblyName>(src.GetReferencedAssemblies().ToSpan());
    }
}