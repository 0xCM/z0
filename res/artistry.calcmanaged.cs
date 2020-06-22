//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class artistry_calcmanaged
    {
        public static ReadOnlySpan<byte> eval_ᐤAddㆍ8uㆍ8uᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc2,0x41,0x0f,0xb6,0xd0,0x03,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eval_ᐤSubㆍ8uㆍ8uᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc2,0x41,0x0f,0xb6,0xd0,0x2b,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eval_ᐤMulㆍ8uㆍ8uᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc2,0x41,0x0f,0xb6,0xd0,0x0f,0xaf,0xc2,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eval_ᐤDivㆍ8uㆍ8uᐤ  =>  new byte[19]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc2,0x41,0x0f,0xb6,0xc8,0x99,0xf7,0xf9,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> eval_ᐤAndㆍ8uㆍ8uᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc2,0x41,0x0f,0xb6,0xd0,0x23,0xc2,0x0f,0xb6,0xc0,0xc3};

    }
}
