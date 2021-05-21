//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.File), StructLayout(LayoutKind.Sequential)]
        public struct FileRow : ICliRecord<FileRow>
        {
            public uint Flags;

            public StringIndex FileName;

            public BlobIndex HashValue;
        }
    }
}