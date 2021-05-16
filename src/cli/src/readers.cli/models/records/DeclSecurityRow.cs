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
        [StructLayout(LayoutKind.Sequential)]
        public struct DeclSecurityRow : ICliRecord<DeclSecurityRow>
        {
            public DeclarativeSecurityAction Action;

            public CliRowKey Parent;

            public BlobIndex PermissionSet;
        }
    }
}