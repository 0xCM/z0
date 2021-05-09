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
        public struct ImplMapRow : ICliRecord<ImplMapRow,ImplMap>
        {
            public CliRowKey<ImplMap> Key;

            public PInvokeAttributes MappingFlags;

            public CliRowKey MemberForwarded;

            public StringIndex ImportName;

            public CliRowKey ImportScope;
        }
    }
}