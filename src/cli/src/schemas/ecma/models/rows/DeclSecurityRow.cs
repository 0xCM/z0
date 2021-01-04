//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct DeclSecurityRow : IRecord<DeclSecurityRow>
    {
        public RowKey Key;

        public DeclarativeSecurityAction Action;

        public Token Parent;

        public FK<BlobIndex> PermissionSet;
    }
}