//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.MemberRef), StructLayout(LayoutKind.Sequential)]
        public struct MemberRefRow : ICliRecord<MemberRefRow>
        {
            public CliRowKey<MemberRef> Key;

        }
    }
}