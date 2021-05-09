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
        [StructLayout(LayoutKind.Sequential)]
        public struct FileRow : ICliRecord<FileRow,File>
        {
            public CliRowKey<File> Key;

            public uint Flags;

            public StringIndex FileName;

            public BlobIndex HashValue;
        }
    }
}