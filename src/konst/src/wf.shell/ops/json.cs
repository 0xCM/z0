//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class WfShell
    {
        [MethodImpl(Inline), Op]
        public static IJsonSettings json(FS.FilePath src)
            => JsonSettings.Load(src);
    }
}