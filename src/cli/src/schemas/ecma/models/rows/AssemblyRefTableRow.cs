//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    using R = AssemblyRefTableRow;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct AssemblyRefTableRow : IRecord<R>
    {
        public const TableIndex TableId = TableIndex.AssemblyRef;

        public RowKey Key;

        public ClrAssemblyVersion Version;

        public FK<bytes> PublicKeyToken;

        public FK<name> Name;

        public FK<name> Culture;

        public AssemblyFlags Flags;

        public FK<bytes> HashValue;
    }
}