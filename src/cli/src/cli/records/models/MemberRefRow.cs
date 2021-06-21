//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.MemberRef), StructLayout(LayoutKind.Sequential)]
        public struct MemberRefRow : ICliRecord<MemberRefRow>
        {
            public CliRowKey Parent;

            public CliStringIndex Name;

            public CliBlobIndex Signature;
        }
    }
}