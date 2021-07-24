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

        public string Name;

        public ushort Width;

        public string Description;

        public bool Emit;
    }
}
