//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct ImageRecords
    {
        [Record, StructLayout(LayoutKind.Sequential)]
        public struct FieldMarshalRow : IRecord<FieldMarshalRow>
        {
            public RowKey Key;

            public RowKey Parent;

            public BlobIndex NativeType;
        }
    }
}