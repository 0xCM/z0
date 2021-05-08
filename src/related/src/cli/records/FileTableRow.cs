//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.File), StructLayout(LayoutKind.Sequential)]
        public struct FileTableRow : IRecord<FileTableRow>
        {
            public CliRowKey Key;

            public uint Flags;

            public StringIndex FileName;

            public BlobIndex HashValue;
        }
    }
}