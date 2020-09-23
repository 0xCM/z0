//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        [MethodImpl(Inline), Op]
        public static Assembly[] owners(in ApiModules src)
            => src.Assemblies.Where(isPart);
    }
}