//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct CliRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRow : ICliRecord<AssemblyRow,CliTableKinds.Assembly>
        {
            public CliRowKey<CliTableKinds.Assembly> Key;

            public AssemblyHashAlgorithm HashAlgorithm;

            public AssemblyVersion Version;

            public AssemblyFlags Flags;

            public BlobIndex PublicKey;

            public StringIndex Name;

            public StringIndex Culture;
        }
    }
}