//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    [Record(CliTableKind.Constant), StructLayout(LayoutKind.Sequential)]
    public struct ConstantRow : IRecord<ConstantRow>
    {
        public RowKey Key;

        public byte Type;

        public RowKey Parent;

        public BlobIndex Value;
    }
}