//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record(CliTableKind.DeclSecurity), StructLayout(LayoutKind.Sequential)]
    public struct DeclSecurityRow : IRecord<DeclSecurityRow>
    {
        public RowKey Key;

        public DeclarativeSecurityAction Action;

        public RowKey Parent;

        public BlobIndex PermissionSet;
    }
}