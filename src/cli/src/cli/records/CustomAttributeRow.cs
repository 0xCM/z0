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
        public struct CustomAttributeRow  : ICliRecord<CustomAttributeRow>
        {
            public CliRowKey Parent;

            public CliRowKey Constructor;

            public BlobIndex Value;

            public Address32 ValueOffset;
        }
    }
}