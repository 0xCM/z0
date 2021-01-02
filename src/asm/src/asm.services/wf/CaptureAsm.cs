//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    partial struct AsmRecapture
    {
        public CapturedApiRes[] Capture(FS.FilePath src, FS.FolderPath dst)
            => ApiRes.capture(Context, src, dst);
    }
}