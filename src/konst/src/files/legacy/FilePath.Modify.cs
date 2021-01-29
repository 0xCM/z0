//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;

    partial class XTend
    {
        public static FilePath CreateParentIfMissing(this FilePath src)
            => FileOps.CreateParent(src);
    }
}