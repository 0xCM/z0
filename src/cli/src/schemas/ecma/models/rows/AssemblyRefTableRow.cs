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

        public FK<BlobIndex> PublicKeyToken;

        public HK<name> Name;

        public HK<name> Culture;

        public AssemblyFlags Flags;

        public FK<BlobIndex> HashValue;
    }
}