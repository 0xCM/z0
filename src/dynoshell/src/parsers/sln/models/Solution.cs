//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static Konst;

    [Record, StructLayout(DefaultLayout)]
    public struct Solution : IRecord<Solution>
    {
        public SlnFile Path;

        public IndexedSeq<SlnProject> Projects;
    }
}