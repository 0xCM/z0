//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-26 14:33:09 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class part_ptr8
    {
        public static ReadOnlySpan<byte> get_Address_ᐤᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0xc3};

        public static ReadOnlySpan<byte> get_Hash_ᐤᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0xd0,0x48,0xc1,0xea,0x20,0x33,0xc2,0xc3};

        public static ReadOnlySpan<byte> Format_ᐤᐤ  =>  new byte[106]{0x48,0x83,0xec,0x38,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0x09,0x48,0xba,0xb0,0x97,0xc6,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x12,0x48,0x85,0xd2,0x75,0x07,0x45,0x33,0xc0,0x33,0xc0,0xeb,0x10,0x44,0x8b,0x02,0x4c,0x8b,0xc2,0x45,0x39,0x00,0x49,0x83,0xc0,0x0c,0x8b,0x42,0x08,0x48,0x8d,0x54,0x24,0x28,0x4c,0x89,0x02,0x89,0x42,0x08,0x48,0x8d,0x54,0x24,0x28,0x45,0x33,0xc0,0xe8,0x11,0x0e,0x16,0x59,0x48,0x8b,0xc8,0x48,0xba,0x68,0x3e,0xe0,0x13,0xd3,0x01,0x00,0x00,0x48,0x8b,0x12,0xe8,0x3c,0x4b,0x11,0x59,0x90,0x48,0x83,0xc4,0x38,0xc3};

        public static ReadOnlySpan<byte> op_LogicalNot_ᐤPtr8ᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0x01,0xc3};

        public static ReadOnlySpan<byte> op_Increment_ᐤPtr8ᐤ  =>  new byte[22]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x48,0x8d,0x44,0x24,0x08,0x48,0xff,0x00,0x48,0x8b,0x00,0xc3};

        public static ReadOnlySpan<byte> op_Decrement_ᐤPtr8ᐤ  =>  new byte[22]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x48,0x8d,0x44,0x24,0x08,0x48,0xff,0x08,0x48,0x8b,0x00,0xc3};

        public static ReadOnlySpan<byte> op_LessThan_ᐤPtr8ㆍPtr8ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x92,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> op_LessThanOrEqual_ᐤPtr8ㆍPtr8ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> op_GreaterThan_ᐤPtr8ㆍPtr8ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x97,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> op_GreaterThanOrEqual_ᐤPtr8ㆍPtr8ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x93,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> op_Equality_ᐤPtr8ㆍPtr8ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x94,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> op_Inequality_ᐤPtr8ㆍPtr8ᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x3b,0xca,0x0f,0x95,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> op_Implicit_ᐤPtr8ᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> op_Implicit_ᐤ8uᕀptrᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> op_Explicit_ᐤPtr8ᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

    }
}
