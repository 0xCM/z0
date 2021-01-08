//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial class XFs
    {
        public static FS.FilePath EnsureParent(this FS.FilePath src)
        {
            FileOps.CreateParent(src.Name.Format());
            return src;
        }

    }
}