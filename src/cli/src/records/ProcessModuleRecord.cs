//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [Record]
    public struct ProcessModuleRecord : IRecord<ProcessModuleRecord>
    {
        public MemoryAddress Base;

        public MemoryAddress Entry;

        public ByteSize Size;

        public utf8 Name;

        public FS.FilePath Path;

        public VersionId Version;
    }
}