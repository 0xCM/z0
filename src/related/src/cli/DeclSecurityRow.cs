//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct CliRecords
    {
        [Record(CliTableKind.DeclSecurity), StructLayout(LayoutKind.Sequential)]
        public struct DeclSecurityRow : IRecord<DeclSecurityRow>
        {
            public CliRowKey Key;

            public DeclarativeSecurityAction Action;

            public CliRowKey Parent;

            public BlobIndex PermissionSet;
        }
    }
}