//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.ImplMap), StructLayout(LayoutKind.Sequential)]
        public struct ImplMapRow : ICliRecord<ImplMapRow>
        {
            public PInvokeAttributes MappingFlags;

            public CliRowKey MemberForwarded;

            public CliStringIndex ImportName;

            public CliRowKey ImportScope;
        }
    }
}