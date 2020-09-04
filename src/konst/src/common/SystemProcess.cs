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
    using System.IO;

    public readonly struct SystemProcess
    {
        public static Process Current
            => Process.GetCurrentProcess();

        public static ProcessModule[] modules()
            => modules(Current);

        public static ProcessModule[] modules(Process src)
            => src.Modules.Cast<ProcessModule>().Array();
    }
}