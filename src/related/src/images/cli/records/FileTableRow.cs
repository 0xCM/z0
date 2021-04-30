//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record, StructLayout(LayoutKind.Sequential)]
        public struct FileTableRow
        {
            public RowKey Key;

            public uint Flags;

            public StringIndex FileName;

            public BlobIndex HashValue;
        }
    }
}