//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.AssemblyRef), StructLayout(LayoutKind.Sequential)]
        public struct AssemblyRefRow : ICliRecord<AssemblyRefRow>
        {
            public CliRowKey Key;

            public AssemblyVersion Version;

            public AssemblyFlags Flags;

            public BlobIndex Token;

            public StringIndex Name;

            public StringIndex Culture;

            public BlobIndex Hash;
        }
    }
}