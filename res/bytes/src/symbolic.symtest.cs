//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class symbolic_symtest
    {
        public static ReadOnlySpan<byte> IsSymbol_ᐤPerm4Lᕀ8uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x80,0xf9,0x03,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> IsSymbol_ᐤPerm8Lᕀ32uᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x83,0xf9,0x07,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> IsSymbol_ᐤPerm16Lᕀ64uᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x83,0xf9,0x0f,0x0f,0x96,0xc0,0x0f,0xb6,0xc0,0xc3};

    }
}
