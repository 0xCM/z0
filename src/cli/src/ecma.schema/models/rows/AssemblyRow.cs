//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System;
    using System.Runtime.InteropServices;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct AssemblyRow  : IRecord<AssemblyRow>
    {
        public const TableIndex TableId = TableIndex.Assembly;

        public RowKey Key;

        public uint HashAlgorithm;

        public ClrAssemblyVersion Version;

        public ushort Flags;

        public FK<bytes> AssemblyKey;

        public FK<name> AssemblyName;

        public FK<name> AssemblyCulture;
    }
}