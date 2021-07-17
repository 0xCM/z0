//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct IntelSdm
    {
        public struct ColumnTypes
        {
            public static ColumnType Opcode => "Opcode";

            public static ColumnType Signature => "Instruction";

            public static ColumnType EncodingRef => "Op/En";

            public static ColumnType Cpuid => "Cpuid";

            public static ColumnType Mode64 => "64-bit Mode";

            public static ColumnType Mode32 => "Compat/Leg Mode";

            public static ColumnType Mode64x32 => "64/32 bit Mode Support";

            public static ColumnType Description => "Description";
        }
    }
}