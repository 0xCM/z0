//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential), Record(TableId)]
    public struct LlvmValueType : IRecord<LlvmValueType>
    {
        public const string TableId = "llvm-value-type";

        public const byte FieldCount = 4;

        public StringAddress Name;

        public ushort Width;

        public StringAddress Description;

        public bool Emit;
    }
}
