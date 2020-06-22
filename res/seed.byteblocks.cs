//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class seed_byteblocks
    {
        public static ReadOnlySpan<byte> alloc_ᐤn1ᐤ  =>  new byte[8]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn2ᐤ  =>  new byte[26]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0xc6,0x04,0x24,0x00,0xc6,0x44,0x24,0x01,0x00,0x48,0x0f,0xbf,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn3ᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x66,0x89,0x01,0x88,0x41,0x02,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn4ᐤ  =>  new byte[20]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0x33,0xc0,0x89,0x04,0x24,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn5ᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x89,0x01,0x88,0x41,0x04,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn6ᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x89,0x01,0x66,0x89,0x41,0x04,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn7ᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x89,0x01,0x66,0x89,0x41,0x04,0x88,0x41,0x06,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn8ᐤ  =>  new byte[22]{0x50,0x33,0xc0,0x48,0x89,0x04,0x24,0x33,0xc0,0x48,0x89,0x04,0x24,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn9ᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x48,0x89,0x01,0x88,0x41,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn10ᐤ  =>  new byte[18]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x48,0x89,0x01,0x66,0x89,0x41,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn11ᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x48,0x89,0x01,0x66,0x89,0x41,0x08,0x88,0x41,0x0a,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn12ᐤ  =>  new byte[17]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x48,0x89,0x01,0x89,0x41,0x08,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn13ᐤ  =>  new byte[20]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x48,0x89,0x01,0x89,0x41,0x08,0x88,0x41,0x0c,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn14ᐤ  =>  new byte[21]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x48,0x89,0x01,0x89,0x41,0x08,0x66,0x89,0x41,0x0c,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn15ᐤ  =>  new byte[24]{0x0f,0x1f,0x44,0x00,0x00,0x33,0xc0,0x48,0x89,0x01,0x89,0x41,0x08,0x66,0x89,0x41,0x0c,0x88,0x41,0x0e,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn16ᐤ  =>  new byte[17]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn32ᐤ  =>  new byte[22]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> alloc_ᐤn64ᐤ  =>  new byte[32]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x7f,0x41,0x10,0xc5,0xfa,0x7f,0x41,0x20,0xc5,0xfa,0x7f,0x41,0x30,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> copy_ᐤuspan8uㆍByteBlock2ᕀrefᐤ  =>  new byte[30]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x0f,0xb6,0x00,0x88,0x02,0x48,0x8d,0x42,0x01,0x48,0x8b,0x09,0x0f,0xb6,0x49,0x01,0x88,0x08,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> copy_ᐤuspan8uㆍByteBlock3ᕀrefᐤ  =>  new byte[39]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x0f,0xb6,0x08,0x88,0x0a,0x48,0x8d,0x4a,0x01,0x44,0x0f,0xb6,0x40,0x01,0x44,0x88,0x01,0x48,0x8d,0x4a,0x02,0x0f,0xb6,0x40,0x02,0x88,0x01,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> copy_ᐤuspan8uㆍByteBlock4ᕀrefᐤ  =>  new byte[51]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x0f,0xb6,0x08,0x88,0x0a,0x48,0x8d,0x4a,0x01,0x44,0x0f,0xb6,0x40,0x01,0x44,0x88,0x01,0x48,0x8d,0x4a,0x02,0x44,0x0f,0xb6,0x40,0x02,0x44,0x88,0x01,0x48,0x8d,0x4a,0x03,0x0f,0xb6,0x40,0x03,0x88,0x01,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> copy_ᐤuspan8uㆍByteBlock8ᕀrefᐤ  =>  new byte[99]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x01,0x0f,0xb6,0x08,0x88,0x0a,0x48,0x8d,0x4a,0x01,0x44,0x0f,0xb6,0x40,0x01,0x44,0x88,0x01,0x48,0x8d,0x4a,0x02,0x44,0x0f,0xb6,0x40,0x02,0x44,0x88,0x01,0x48,0x8d,0x4a,0x03,0x44,0x0f,0xb6,0x40,0x03,0x44,0x88,0x01,0x48,0x8d,0x4a,0x04,0x44,0x0f,0xb6,0x40,0x04,0x44,0x88,0x01,0x48,0x8d,0x4a,0x05,0x44,0x0f,0xb6,0x40,0x05,0x44,0x88,0x01,0x48,0x8d,0x4a,0x06,0x44,0x0f,0xb6,0x40,0x06,0x44,0x88,0x01,0x48,0x8d,0x4a,0x07,0x0f,0xb6,0x40,0x07,0x88,0x01,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> copy_ᐤuspan8uㆍByteBlock16ᕀrefᐤ  =>  new byte[34]{0x48,0x83,0xec,0x28,0xc5,0xf8,0x77,0x48,0x8b,0x01,0xc5,0xfb,0xf0,0x00,0x48,0x8b,0xc2,0xc5,0xfa,0x7f,0x00,0x48,0x8b,0xc2,0x48,0x83,0xc4,0x28,0xc3,0xe8,0x1e,0xab,0x41,0x5d};

        public static ReadOnlySpan<byte> copy_ᐤuspan8uㆍByteBlock32ᕀrefᐤ  =>  new byte[37]{0x48,0x83,0xec,0x28,0xc5,0xf8,0x77,0x48,0x8b,0x01,0xc5,0xff,0xf0,0x00,0x48,0x8b,0xc2,0xc5,0xfe,0x7f,0x00,0x48,0x8b,0xc2,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x28,0xc3,0xe8,0xdb,0xaa,0x41,0x5d};

        public static ReadOnlySpan<byte> copy_ᐤuspan8uㆍByteBlock64ᕀrefᐤ  =>  new byte[56]{0x48,0x83,0xec,0x28,0xc5,0xf8,0x77,0x48,0x8b,0x01,0x48,0x8b,0xc8,0xc5,0xff,0xf0,0x01,0x48,0x83,0xc0,0x20,0xc5,0xff,0xf0,0x08,0x48,0x8b,0xc2,0xc5,0xfe,0x7f,0x00,0x48,0x8d,0x42,0x20,0xc5,0xfe,0x7f,0x08,0x48,0x8b,0xc2,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x28,0xc3,0xe8,0x78,0xa6,0x41,0x5d};

        public static ReadOnlySpan<byte> init_ᐤv256x16uㆍv256x16uᐤ  =>  new byte[128]{0x57,0x56,0x48,0x81,0xec,0x88,0x00,0x00,0x00,0xc5,0xf8,0x77,0x48,0x8b,0xf1,0x48,0x8d,0x7c,0x24,0x28,0xb9,0x18,0x00,0x00,0x00,0x33,0xc0,0xf3,0xab,0x48,0x8b,0xce,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc5,0xfd,0x11,0x44,0x24,0x48,0xc5,0xfd,0x11,0x4c,0x24,0x68,0x48,0x8d,0x44,0x24,0x28,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x00,0xc5,0xfa,0x7f,0x40,0x10,0x48,0x8d,0x44,0x24,0x48,0xc5,0xff,0xf0,0x00,0xc5,0xfe,0x7f,0x44,0x24,0x28,0xc5,0xfa,0x6f,0x44,0x24,0x28,0xc5,0xfa,0x7f,0x01,0xc5,0xfa,0x6f,0x44,0x24,0x38,0xc5,0xfa,0x7f,0x41,0x10,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0x48,0x81,0xc4,0x88,0x00,0x00,0x00,0x5e,0x5f,0xc3,0xe8,0xd0,0xa5,0x41,0x5d};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock2ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock3ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock4ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock5ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock6ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock7ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock8ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock9ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock10ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock11ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock12ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock13ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock14ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock15ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock16ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock32ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8r_ᐤByteBlock64ᕀinᐤ  =>  new byte[9]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock2ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x02,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock3ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x03,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock4ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x04,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock5ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x05,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock6ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x06,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock7ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x07,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock8ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x08,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock9ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x09,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock10ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x0a,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock11ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x0b,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock12ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x0c,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock13ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x0d,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock14ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x0e,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock15ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x0f,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock16ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x10,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock32ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x20,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

        public static ReadOnlySpan<byte> u8s_ᐤByteBlock64ᕀinᐤ  =>  new byte[25]{0x48,0x83,0xec,0x28,0x90,0xb8,0x40,0x00,0x00,0x00,0x48,0x89,0x11,0x89,0x41,0x08,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x28,0xc3,0xe8};

    }
}
