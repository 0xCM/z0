//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct TypeDefRow : ICliRecord<TypeDefRow,TypeDef>
        {
            public CliRowKey<TypeDef> Key;

            public uint Flags;

            public StringIndex Name;

            public StringIndex Namespace;

            public int Extends;

            public int FieldList;

            public int MethodList;
        }
    }
}