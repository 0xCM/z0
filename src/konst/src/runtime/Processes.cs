//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Diagnostics;

    using static Part;

    using A = Z0.Adapters;

    [ApiHost]
    public readonly partial struct Processes
    {
        [Op]
        public static ReadOnlySpan<A.ProcessModule> modules(Process src)
            => src.Modules.Cast<ProcessModule>().Select(m => A.ProcessModule.adapt(m)).Array();

        [MethodImpl(Inline), Op]
        public static A.Process current()
            => Process.GetCurrentProcess();
    }
}
