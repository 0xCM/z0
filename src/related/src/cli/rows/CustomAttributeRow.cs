//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(CliTableKind.CustomAttribute), StructLayout(LayoutKind.Sequential)]
        public struct CustomAttributeRow  : IRecord<CustomAttributeRow>
        {
            public RowKey Key;

            public RowKey Parent;

            public RowKey Type;

            public BlobIndex Value;
        }
    }
}