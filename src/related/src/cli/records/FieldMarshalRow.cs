//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    using static CliTableKinds;

    partial struct CliRecords
    {
        [Record(CliTableKind.FieldMarshal), StructLayout(LayoutKind.Sequential)]
        public struct FieldMarshalRow : ICliRecord<FieldMarshalRow>
        {
            public CliRowKey<FieldMarshal> Key;

            public CliRowKey Parent;

            public BlobIndex NativeType;
        }
    }
}