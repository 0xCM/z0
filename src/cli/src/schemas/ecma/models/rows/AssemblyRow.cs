//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    using static Relations;

    [Record(TableId), StructLayout(LayoutKind.Sequential)]
    public struct AssemblyRow : IRecord<AssemblyRow>
    {
        public const ClrTableKind TableId = ClrTableKind.Assembly;

        public RowKey Key;

        public AssemblyHashAlgorithm HashAlgorithm;

        public ClrAssemblyVersion Version;

        public AssemblyFlags Flags;

        public FK<BlobIndex> AssemblyKey;

        public FK<StringIndex> AssemblyName;

        public FK<StringIndex> AssemblyCulture;
    }
}