//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record(CliTableKind.FieldMarshal), StructLayout(LayoutKind.Sequential)]
        public struct FieldMarshalRow : ICliRecord<FieldMarshalRow>
        {
            public CliRowKey Key;

            public CliRowKey Parent;

            public BlobIndex NativeType;
        }
    }
}