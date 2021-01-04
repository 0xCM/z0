//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct DeclSecurityRow : IRecord<DeclSecurityRow>
    {
        public RowKey Key;

        public ushort Action;

        public token Parent;

        public FK<bytes> PermissionSet;
    }
}