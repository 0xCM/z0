//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct ImplMapRow : ICliRecord<ImplMapRow>
        {
            public PInvokeAttributes MappingFlags;

            public CliRowKey MemberForwarded;

            public StringIndex ImportName;

            public CliRowKey ImportScope;
        }
    }
}