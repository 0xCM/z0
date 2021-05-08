//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct PeRecords
    {
        [StructLayout(LayoutKind.Sequential), Record(TableId)]
        public struct DirectoryEntryRow : IRecord<DirectoryEntryRow>
        {
            public const string TableId = "pe.directory-entry";

            public Address32 Rva;

            public uint Size;
        }
    }
}