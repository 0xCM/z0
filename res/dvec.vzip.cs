//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class dvec_vzip
    {
        public static ReadOnlySpan<byte> vzip_ᐤv128x16iㆍv128x16iㆍW8ᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xf9,0x63,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv128x16iㆍv128x16iㆍW8ㆍn0ᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xf9,0x67,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv256x16iㆍv256x16iㆍW8ᐤ  =>  new byte[35]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc5,0xfd,0x63,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv128x16uㆍv128x16uㆍW8ᐤ  =>  new byte[58]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc7,0x44,0x24,0x04,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x04,0xc4,0xe2,0x79,0x79,0x54,0x24,0x04,0xc5,0xf9,0xdb,0xc2,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0x67,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv256x16uㆍv256x16uㆍW8ᐤ  =>  new byte[67]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc7,0x44,0x24,0x04,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x04,0xc4,0xe2,0x7d,0x79,0x54,0x24,0x04,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x67,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv128x32iㆍv128x32iㆍW16ᐤ  =>  new byte[26]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc5,0xf9,0x6b,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv256x32iㆍv256x32iㆍW16ᐤ  =>  new byte[35]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc5,0xfd,0x6b,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv128x32uㆍv128x32uㆍW16ᐤ  =>  new byte[59]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc7,0x44,0x24,0x04,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x04,0xc4,0xe2,0x79,0x58,0x54,0x24,0x04,0xc5,0xf9,0xdb,0xc2,0xc5,0xf1,0xdb,0xca,0xc4,0xe2,0x79,0x2b,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv128x32iㆍv128x32iㆍW16ㆍn0ᐤ  =>  new byte[27]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc4,0xe2,0x79,0x2b,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv256x16iㆍv256x16iㆍn8ㆍn0ᐤ  =>  new byte[29]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc5,0xfd,0x67,0xc1,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv256x32iㆍv256x32iㆍn16ㆍn0ᐤ  =>  new byte[30]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc4,0xe2,0x7d,0x2b,0xc1,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv256x32uㆍv256x32uㆍW16ᐤ  =>  new byte[68]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc7,0x44,0x24,0x04,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x04,0xc4,0xe2,0x7d,0x58,0x54,0x24,0x04,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc4,0xe2,0x7d,0x2b,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv256x32uㆍv256x32uㆍW8ᐤ  =>  new byte[109]{0x50,0xc5,0xf8,0x77,0x90,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc7,0x44,0x24,0x04,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x04,0xc4,0xe2,0x7d,0x58,0x54,0x24,0x04,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc4,0xe2,0x7d,0x2b,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xc4,0xe3,0x7d,0x19,0xc1,0x00,0xc4,0xe3,0x7d,0x19,0xc0,0x01,0xc7,0x04,0x24,0xff,0x00,0x00,0x00,0x48,0x8d,0x04,0x24,0xc4,0xe2,0x79,0x79,0x14,0x24,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0xdb,0xc2,0xc5,0xf1,0x67,0xc0,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x08,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv128x64uㆍv128x64uㆍW32ᐤ  =>  new byte[74]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc5,0xf8,0x28,0xc8,0xc4,0xe1,0xf9,0x7e,0xc8,0xc4,0xe3,0xf9,0x16,0xc2,0x01,0xc4,0xc1,0x79,0x10,0x00,0xc5,0xf8,0x28,0xc8,0xc4,0xc1,0xf9,0x7e,0xc8,0xc4,0xc3,0xf9,0x16,0xc1,0x01,0xc5,0xf9,0x6e,0xc0,0xc4,0xe3,0x79,0x22,0xc2,0x01,0xc4,0xc3,0x79,0x22,0xc0,0x02,0xc4,0xc3,0x79,0x22,0xc1,0x03,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv256x64uㆍv256x64uㆍW32ᐤ  =>  new byte[169]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x02,0xc5,0xfc,0x28,0xc8,0xc4,0xe1,0xf9,0x7e,0xc8,0xc5,0xfc,0x28,0xc8,0xc4,0xe3,0xf9,0x16,0xca,0x01,0xc4,0xe3,0x7d,0x19,0xc1,0x01,0xc4,0xc1,0xf9,0x7e,0xc9,0xc4,0xe3,0x7d,0x19,0xc0,0x01,0xc4,0xc3,0xf9,0x16,0xc2,0x01,0xc5,0xf9,0x6e,0xc0,0xc4,0xe3,0x79,0x22,0xc2,0x01,0xc4,0xc3,0x79,0x22,0xc1,0x02,0xc4,0xc3,0x79,0x22,0xc2,0x03,0xc4,0xc1,0x7d,0x10,0x08,0xc5,0xfc,0x28,0xd1,0xc4,0xe1,0xf9,0x7e,0xd0,0xc5,0xfc,0x28,0xd1,0xc4,0xe3,0xf9,0x16,0xd2,0x01,0xc4,0xe3,0x7d,0x19,0xca,0x01,0xc4,0xc1,0xf9,0x7e,0xd0,0xc4,0xe3,0x7d,0x19,0xc9,0x01,0xc4,0xc3,0xf9,0x16,0xc9,0x01,0xc5,0xf9,0x6e,0xc8,0xc4,0xe3,0x71,0x22,0xca,0x01,0xc4,0xc3,0x71,0x22,0xc8,0x02,0xc4,0xc3,0x71,0x22,0xc9,0x03,0xc5,0xec,0x57,0xd2,0xc4,0xe3,0x6d,0x38,0xc0,0x00,0xc4,0xe3,0x7d,0x38,0xc1,0x01,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv128x32uㆍv128x32uㆍv128x32uㆍv128x32uㆍW8ᐤ  =>  new byte[140]{0x48,0x83,0xec,0x18,0xc5,0xf8,0x77,0x48,0x8b,0x44,0x24,0x40,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc7,0x44,0x24,0x14,0xff,0xff,0x00,0x00,0x48,0x8d,0x54,0x24,0x14,0xc4,0xe2,0x79,0x58,0x54,0x24,0x14,0xc5,0xf9,0xdb,0xc2,0xc5,0xf1,0xdb,0xca,0xc4,0xe2,0x79,0x2b,0xc1,0xc4,0xc1,0x79,0x10,0x09,0xc5,0xf9,0x10,0x10,0xc7,0x44,0x24,0x10,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x10,0xc4,0xe2,0x79,0x58,0x5c,0x24,0x10,0xc5,0xf1,0xdb,0xcb,0xc5,0xe9,0xdb,0xd3,0xc4,0xe2,0x71,0x2b,0xca,0xc7,0x44,0x24,0x0c,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x0c,0xc4,0xe2,0x79,0x79,0x54,0x24,0x0c,0xc5,0xf9,0xdb,0xc2,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0x67,0xc1,0xc5,0xf9,0x11,0x01,0x48,0x8b,0xc1,0x48,0x83,0xc4,0x18,0xc3};

        public static ReadOnlySpan<byte> vzip_ᐤv256x32uㆍv256x32uㆍv256x32uㆍv256x32uㆍW8ᐤ  =>  new byte[161]{0x48,0x83,0xec,0x18,0xc5,0xf8,0x77,0x48,0x8b,0x44,0x24,0x40,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc7,0x44,0x24,0x14,0xff,0xff,0x00,0x00,0x48,0x8d,0x54,0x24,0x14,0xc4,0xe2,0x7d,0x58,0x54,0x24,0x14,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc4,0xe2,0x7d,0x2b,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xc4,0xc1,0x7d,0x10,0x09,0xc5,0xfd,0x10,0x10,0xc7,0x44,0x24,0x10,0xff,0xff,0x00,0x00,0x48,0x8d,0x44,0x24,0x10,0xc4,0xe2,0x7d,0x58,0x5c,0x24,0x10,0xc5,0xf5,0xdb,0xcb,0xc5,0xed,0xdb,0xd3,0xc4,0xe2,0x75,0x2b,0xca,0xc4,0xe3,0xfd,0x00,0xc9,0xd8,0xc7,0x44,0x24,0x0c,0xff,0x00,0x00,0x00,0x48,0x8d,0x44,0x24,0x0c,0xc4,0xe2,0x7d,0x79,0x54,0x24,0x0c,0xc5,0xfd,0xdb,0xc2,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x67,0xc1,0xc4,0xe3,0xfd,0x00,0xc0,0xd8,0xc5,0xfd,0x11,0x01,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0x48,0x83,0xc4,0x18,0xc3};

    }
}
