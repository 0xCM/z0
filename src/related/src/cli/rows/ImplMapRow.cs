//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(CliTableKind.ImplMap), StructLayout(LayoutKind.Sequential)]
        public struct ImplMapRow
        {
            public RowKey Key;

            public PInvokeAttributes MappingFlags;

            public RowKey MemberForwarded;

            public StringIndex ImportName;

            public RowKey ImportScope;
        }
    }
}