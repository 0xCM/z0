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
        [Record(CliTableKind.Field), StructLayout(LayoutKind.Sequential)]
        public struct FieldRow : ICliRecord<FieldRow>
        {
            public CliRowKey<Field> Key;

            public FieldAttributes Flags;

            public StringIndex Name;

            public BlobIndex Signature;
        }
    }
}