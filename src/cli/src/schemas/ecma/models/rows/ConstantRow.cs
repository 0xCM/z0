//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Schemas.Ecma
{
    using System.Runtime.InteropServices;

    [Record, StructLayout(LayoutKind.Sequential)]
    public struct ConstantRow : IRecord<ConstantRow>
    {
        public RowKey Key;

        public byte Type;

        public int Parent;

        public FK<BlobIndex> Value;
    }
}