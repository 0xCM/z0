//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRecords
    {
        [Record, StructLayout(LayoutKind.Sequential)]
        public struct FieldMarshalRow : IRecord<FieldMarshalRow>
        {
            public CliRowKey Key;

            public CliRowKey Parent;

            public BlobIndex NativeType;
        }
    }
}