//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.ImplMap), StructLayout(LayoutKind.Sequential)]
        public struct ImplMapRow : ICliRecord<ImplMapRow>
        {
            public CliRowKey Key;

            public PInvokeAttributes MappingFlags;

            public CliRowKey MemberForwarded;

            public StringIndex ImportName;

            public CliRowKey ImportScope;
        }
    }
}