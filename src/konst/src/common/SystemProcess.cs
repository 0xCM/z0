//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;
    using System.Linq;

    using static Konst;

    [ApiHost]
    public readonly struct SystemProcess
    {
        [MethodImpl(Inline), Op]
        public static Process current()
            => Process.GetCurrentProcess();

        [MethodImpl(Inline), Op]
        public static ProcessModule[] modules()
            => modules(current());

        [MethodImpl(Inline), Op]
        public static ProcessModule[] modules(Process src)
            => src.Modules.Cast<ProcessModule>().Array();
    }
}