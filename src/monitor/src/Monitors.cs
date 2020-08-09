//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost]
    public readonly struct Monitors
    {
        [MethodImpl(Inline), Op]
        public static IDirectoryMonitor monitor(FolderPath src, DirectoryMonitor.ChangeHandler handler, bool recursive = true, string filter = null)
            => new DirectoryMonitor(src, handler, recursive, filter);
    }
}