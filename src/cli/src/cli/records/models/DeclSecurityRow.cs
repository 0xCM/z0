//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct CliRows
    {
        [CliRecord(CliTableKind.DeclSecurity), StructLayout(LayoutKind.Sequential)]
        public struct DeclSecurityRow : ICliRecord<DeclSecurityRow>
        {
            public DeclarativeSecurityAction Action;

            public CliRowKey Parent;

            public CliBlobIndex PermissionSet;
        }
    }
}