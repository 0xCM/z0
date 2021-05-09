//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Reflection;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct ExportedTypeRow  : ICliRecord<ExportedTypeRow,ExportedType>
        {
            public CliRowKey<ExportedType> Key;

            public TypeAttributes Flags;

            public CliRowKey TypeDefId;

            public StringIndex TypeName;

            public StringIndex TypeNamespace;

            public CliRowKey Implementation;
        }
    }
}