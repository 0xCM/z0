//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class XTend
    {
        public static FS.FileName Component(this PartId part, FS.FileExt ext)
            => FS.component(part, ext);

        public static FS.FileName Component(this PartId part, FS.FileExt x1, FS.FileExt x2)
            => FS.component(part, x1, x2);
    }
}