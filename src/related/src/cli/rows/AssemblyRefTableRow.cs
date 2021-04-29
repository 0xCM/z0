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
        [Record(CliTableKind.AssemblyRef), StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefTableRow : IRecord<AssemblyRefTableRow>
        {
            public RowKey Key;

            public ClrAssemblyVersion Version;

            public BlobIndex PublicKeyToken;

            public StringIndex Name;

            public StringIndex Culture;

            public AssemblyFlags Flags;

            public BlobIndex HashValue;
        }
    }
}