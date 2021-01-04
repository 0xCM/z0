//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ecma.Schema
{
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct FieldMarshalRow : IRecord<FieldMarshalRow>
    {
        public RowKey Key;

        public int Parent;

        public FK<byte> NativeType;
    }
}