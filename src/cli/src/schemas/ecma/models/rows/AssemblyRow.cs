//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System;
    using System.Runtime.InteropServices;

    [Record(CliTableKind.Assembly), StructLayout(LayoutKind.Sequential)]
    public struct AssemblyRow : IRecord<AssemblyRow>
    {
        public RowKey Key;

        public AssemblyHashAlgorithm HashAlgorithm;

        public ClrAssemblyVersion Version;

        public AssemblyFlags Flags;

        public BlobIndex AssemblyKey;

        public StringIndex AssemblyName;

        public StringIndex AssemblyCulture;
    }
}