//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class dvec_vmov
    {
        public static ReadOnlySpan<byte> vmove_ᐤv128x8iㆍn8ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x7e,0xc0,0x48,0x0f,0xbe,0xc0,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x8uㆍn8ᐤ  =>  new byte[17]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x7e,0xc0,0x0f,0xb6,0xc0,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x16iㆍn16ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x7e,0xc0,0x48,0x0f,0xbf,0xc0,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x16uㆍW16ᐤ  =>  new byte[17]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x7e,0xc0,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x32iㆍn32ᐤ  =>  new byte[14]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x7e,0xc0,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x32uㆍn32ᐤ  =>  new byte[14]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x7e,0xc0,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x64iㆍn64ᐤ  =>  new byte[15]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc4,0xe1,0xf9,0x7e,0xc0,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x64uㆍn64ᐤ  =>  new byte[15]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc4,0xe1,0xf9,0x7e,0xc0,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x32uㆍv128x64uᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xc1,0x79,0x10,0x00,0xc5,0xf9,0x10,0x0a,0xc5,0xfa,0x5a,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x32iㆍv128x64iᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xc1,0x79,0x10,0x00,0xc5,0xf9,0x10,0x0a,0xc5,0xfa,0x5a,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x16uㆍW16ㆍn3ㆍn0ᐤ  =>  new byte[22]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xfb,0x70,0xc0,0x27,0xc5,0xf9,0x7e,0xc0,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x16uㆍW16ㆍn2ㆍn0ᐤ  =>  new byte[22]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xfb,0x70,0xc0,0x36,0xc5,0xf9,0x7e,0xc0,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤv128x16uㆍW16ㆍn1ㆍn0ᐤ  =>  new byte[22]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xfb,0x70,0xc0,0x39,0xc5,0xf9,0x7e,0xc0,0x0f,0xb7,0xc0,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍn2ㆍW64ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x32,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍn4ㆍW32ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x31,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍn4ㆍW64ᐤ  =>  new byte[21]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x7d,0x32,0x02,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍn8ㆍW16ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x30,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍn8ㆍW32ᐤ  =>  new byte[21]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x7d,0x31,0x02,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍn16ㆍW16ᐤ  =>  new byte[21]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x7d,0x30,0x02,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ16uᕀinㆍn2ㆍW64ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x34,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ16uᕀinㆍn4ㆍW64ᐤ  =>  new byte[21]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x7d,0x34,0x02,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ16uᕀinㆍn4ㆍW32ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x33,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ16uᕀinㆍn8ㆍW32ᐤ  =>  new byte[21]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x7d,0x33,0x02,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍn2ㆍW64ㆍn1ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x32,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍn128ㆍW32ㆍn1ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x31,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍW256ㆍW64ㆍn1ᐤ  =>  new byte[21]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x7d,0x32,0x02,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍn8ㆍW16ㆍn1ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x30,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍn16ㆍW16ㆍn1ᐤ  =>  new byte[21]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x7d,0x30,0x02,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ16iᕀinㆍn2ㆍW64ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x24,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ16iᕀinㆍn4ㆍW32ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x23,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ16uᕀinㆍn2ㆍW64ㆍn1ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x34,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ32iᕀinㆍn2ㆍW64ᐤ  =>  new byte[18]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xe2,0x79,0x25,0x02,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ16uᕀinㆍn16ㆍW32ᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x8b,0xc2,0xc4,0xe2,0x7d,0x33,0x00,0x48,0x83,0xc2,0x10,0xc4,0xe2,0x7d,0x33,0x0a,0xc5,0xfd,0x11,0x01,0xc5,0xfd,0x11,0x49,0x20,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ16iᕀinㆍn16ㆍW32ᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x8b,0xc2,0xc4,0xe2,0x7d,0x23,0x00,0x48,0x83,0xc2,0x10,0xc4,0xe2,0x7d,0x23,0x0a,0xc5,0xfd,0x11,0x01,0xc5,0xfd,0x11,0x49,0x20,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ8uᕀinㆍn32ㆍW16ᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x8b,0xc2,0xc4,0xe2,0x7d,0x30,0x00,0x48,0x83,0xc2,0x10,0xc4,0xe2,0x7d,0x30,0x0a,0xc5,0xfd,0x11,0x01,0xc5,0xfd,0x11,0x49,0x20,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ16uᕀinㆍn8ㆍW64ᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x8b,0xc2,0xc4,0xe2,0x7d,0x34,0x00,0x48,0x83,0xc2,0x08,0xc4,0xe2,0x7d,0x34,0x0a,0xc5,0xfd,0x11,0x01,0xc5,0xfd,0x11,0x49,0x20,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vmove_ᐤ32uᕀinㆍn8ㆍW64ᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x8b,0xc2,0xc4,0xe2,0x7d,0x25,0x00,0x48,0x83,0xc2,0x10,0xc4,0xe2,0x7d,0x25,0x0a,0xc5,0xfd,0x11,0x01,0xc5,0xfd,0x11,0x49,0x20,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

    }
}
