//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static z;

    partial struct AsmRecapture
    {
        public CapturedApiResource[] Capture(FS.FilePath src, FS.FolderPath dst)
            => ApiResources.capture(Context, src, dst);
    }
}