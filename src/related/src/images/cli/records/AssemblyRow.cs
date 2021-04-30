//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct Images
    {
        [Record(CliTableKind.Assembly), StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRow : IRecord<AssemblyRow>
        {
            public RowKey Key;

            public AssemblyHashAlgorithm HashAlgorithm;

            public AssemblyVersion Version;

            public AssemblyFlags Flags;

            public BlobIndex PublicKey;

            public StringIndex Name;

            public StringIndex Culture;
        }
    }
}