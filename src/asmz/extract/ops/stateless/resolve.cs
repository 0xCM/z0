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
    using static memory;

    partial class ApiExtractor
    {
        [MethodImpl(Inline), Op]
        static ResolvedMethod resolve(MethodInfo method, OpUri uri, MemoryAddress address)
            => new ResolvedMethod(method, uri, address);
    }
}