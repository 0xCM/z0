//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public struct Solution
    {
        public FS.FilePath Path;

        public IndexedSeq<SlnProject> Projects;
    }
}