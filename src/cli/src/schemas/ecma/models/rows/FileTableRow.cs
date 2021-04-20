//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    using static Relations;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct FileTableRow
    {
        public RowKey Key;

        public uint Flags;

        public FK<StringIndex> FileName;

        public FK<BlobIndex> HashValue;
    }
}