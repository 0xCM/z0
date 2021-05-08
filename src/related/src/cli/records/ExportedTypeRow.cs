//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;
    using System.Reflection;

    partial struct CliRecords
    {
        [Record(CliTableKind.ExportedType), StructLayout(LayoutKind.Sequential)]
        public struct ExportedTypeRow  : IRecord<ExportedTypeRow>
        {
            public CliRowKey Key;

            public TypeAttributes Flags;

            public CliRowKey TypeDefId;

            public StringIndex TypeName;

            public StringIndex TypeNamespace;

            public CliRowKey Implementation;
        }
    }
}