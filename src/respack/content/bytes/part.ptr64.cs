//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
// Generated   : 2021-02-25 19:10:09 -06:00
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class part_ptr64
    {
        public static ReadOnlySpan<byte> get_Hash_ᐤᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x48,0x8b,0xd0,0x48,0xc1,0xea,0x20,0x33,0xc2,0xc3};

        public static ReadOnlySpan<byte> get_Address_ᐤᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0xc3};

        public static ReadOnlySpan<byte> Format_ᐤᐤ  =>  new byte[106]{0x48,0x83,0xec,0x38,0x33,0xc0,0x48,0x89,0x44,0x24,0x28,0x48,0x8b,0x09,0x48,0xba,0xb0,0x97,0x2c,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0x48,0x85,0xd2,0x75,0x07,0x45,0x33,0xc0,0x33,0xc0,0xeb,0x10,0x44,0x8b,0x02,0x4c,0x8b,0xc2,0x45,0x39,0x00,0x49,0x83,0xc0,0x0c,0x8b,0x42,0x08,0x48,0x8d,0x54,0x24,0x28,0x4c,0x89,0x02,0x89,0x42,0x08,0x48,0x8d,0x54,0x24,0x28,0x45,0x33,0xc0,0xe8,0xe1,0x50,0xf3,0x4c,0x48,0x8b,0xc8,0x48,0xba,0xf8,0x3c,0x46,0xe7,0x8f,0x02,0x00,0x00,0x48,0x8b,0x12,0xe8,0x0c,0x8e,0xee,0x4c,0x90,0x48,0x83,0xc4,0x38,0xc3};

        public static ReadOnlySpan<byte> op_LogicalNot_ᐤPtr64ᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0xc3};

        public static ReadOnlySpan<byte> op_Increment_ᐤPtr64ᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x48,0x8d,0x44,0x24,0x08,0x48,0x83,0x00,0x08,0x48,0x8b,0x00,0xc3};

        public static ReadOnlySpan<byte> op_Decrement_ᐤPtr64ᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x89,0x4c,0x24,0x08,0x48,0x8d,0x44,0x24,0x08,0x48,0x83,0x00,0xf8,0x48,0x8b,0x00,0xc3};

        public static ReadOnlySpan<byte> op_Implicit_ᐤPtr64ᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> op_Implicit_ᐤIntPtrᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> op_Explicit_ᐤPtr64ᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> op_Implicit_ᐤ64uᕀptrᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

    }
}
