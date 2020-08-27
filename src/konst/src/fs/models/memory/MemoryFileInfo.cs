//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    [Table]
    public struct MemoryFileInfo : ITable<MemoryFileInfo>
    {
        public MemoryAddress BaseAddress;

        public FS.EntryDetail Description;
    }
}