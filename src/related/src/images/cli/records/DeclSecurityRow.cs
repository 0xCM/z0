//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct ImageRecords
    {
        [Record(CliTableKind.DeclSecurity), StructLayout(LayoutKind.Sequential)]
        public struct DeclSecurityRow : IRecord<DeclSecurityRow>
        {
            public RowKey Key;

            public DeclarativeSecurityAction Action;

            public RowKey Parent;

            public BlobIndex PermissionSet;
        }
    }
}