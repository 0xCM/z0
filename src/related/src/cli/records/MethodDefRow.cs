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
        [Record(CliTableKind.MethodDef), StructLayout(LayoutKind.Sequential)]
        public struct MethodDefRow : ICliRecord<MethodDefRow>
        {
            public CliRowKey<MethodDef> Key;

            public Address32 Rva;

            public MethodImplAttributes ImplAttributes;

            public MethodAttributes Attributes;

            public StringIndex Name;

            public BlobIndex Signature;

            public CliRowKey FirstParam;

            public ushort ParamCount;
        }
    }
}