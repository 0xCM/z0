//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    partial struct Images
    {
        [Record(CliTableKind.Constant), StructLayout(LayoutKind.Sequential)]
        public struct ConstantRow : IRecord<ConstantRow>
        {
            public RowKey Key;

            public byte Type;

            public RowKey Parent;

            public BlobIndex Value;
        }
    }
}