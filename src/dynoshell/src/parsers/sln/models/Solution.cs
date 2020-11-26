//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [Record]
    public struct Solution : IRecord<Solution>
    {
        public SlnFile Path;

        public IndexedSeq<SlnProject> Projects;
    }
}