//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.DeclSecurity), StructLayout(LayoutKind.Sequential)]
        public struct DeclSecurityRow : ICliRecord<DeclSecurityRow>
        {
            public CliRowKey Key;

            public DeclarativeSecurityAction Action;

            public CliRowKey Parent;

            public BlobIndex PermissionSet;
        }
    }
}