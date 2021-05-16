//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct CliRows
    {
        [StructLayout(LayoutKind.Sequential)]
        public struct FieldMarshalRow : ICliRecord<FieldMarshalRow>
        {

            public CliRowKey Parent;

            public BlobIndex NativeType;
        }
    }
}