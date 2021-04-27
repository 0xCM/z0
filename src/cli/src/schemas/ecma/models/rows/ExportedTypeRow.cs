//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;
    using System.Reflection;

    [Record(CliTableKind.ExportedType), StructLayout(LayoutKind.Sequential)]
    public struct ExportedTypeRow  : IRecord<ExportedTypeRow>
    {
        public RowKey Key;

        public TypeAttributes Flags;

        public RowKey TypeDefId;

        public StringIndex TypeName;

        public StringIndex TypeNamespace;

        public RowKey Implementation;
    }
}