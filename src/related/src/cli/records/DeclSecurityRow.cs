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
        [StructLayout(LayoutKind.Sequential)]
        public struct DeclSecurityRow : ICliRecord<DeclSecurityRow,DeclSecurity>
        {
            public CliRowKey<DeclSecurity> Key;

            public DeclarativeSecurityAction Action;

            public CliRowKey Parent;

            public BlobIndex PermissionSet;
        }
    }
}