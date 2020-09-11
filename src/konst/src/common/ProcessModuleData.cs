//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct ProcessModuleData
    {
        public MemoryAddress Base;

        public MemoryAddress Entry;

        public ByteSize Size;

        public StringRef Name;

        public FS.FilePath Path;

        public VersionId Version;
    }
}