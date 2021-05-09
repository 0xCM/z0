//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.File), StructLayout(LayoutKind.Sequential)]
        public struct FileRow : ICliRecord<FileRow>
        {
            public CliRowKey<File> Key;

            public uint Flags;

            public StringIndex FileName;

            public BlobIndex HashValue;
        }
    }
}