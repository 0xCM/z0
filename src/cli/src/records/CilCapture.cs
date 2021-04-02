//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [Record(TableId)]
    public struct CilCapture : IRecord<CilCapture>
    {
        public const string TableId = "cil.data";

        public const byte FieldCount = 4;

        public ClrToken MemberId;

        public MemoryAddress BaseAddress;

        public OpUri Uri;

        public BinaryCode CilCode;
    }
}