//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;


    public static class seed_memstores
    {
        public static ReadOnlySpan<byte> load_gᐸ8uᐳᐤMemRefᕀinᐤ  =>  new byte[33]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xc1,0x79,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0xc4,0xe3,0xf9,0x16,0xc1,0x01,0x8b,0xc9,0x48,0x89,0x02,0x89,0x4a,0x08,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> load_gᐸ16uᐳᐤMemRefᕀinᐤ  =>  new byte[33]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xc1,0x79,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0xc4,0xe3,0xf9,0x16,0xc1,0x01,0x8b,0xc9,0x48,0x89,0x02,0x89,0x4a,0x08,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> load_gᐸ32uᐳᐤMemRefᕀinᐤ  =>  new byte[33]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xc1,0x79,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0xc4,0xe3,0xf9,0x16,0xc1,0x01,0x8b,0xc9,0x48,0x89,0x02,0x89,0x4a,0x08,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> load_gᐸ64uᐳᐤMemRefᕀinᐤ  =>  new byte[33]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xc1,0x79,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0xc4,0xe3,0xf9,0x16,0xc1,0x01,0x8b,0xc9,0x48,0x89,0x02,0x89,0x4a,0x08,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> cell_gᐸ8uᐳᐤuspan8uㆍ32iᐤ  =>  new byte[15]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x49,0x63,0xd0,0x48,0x03,0xc2,0xc3};

        public static ReadOnlySpan<byte> cell_gᐸ16uᐳᐤuspan16uㆍ32iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x49,0x63,0xd0,0x48,0x8d,0x04,0x50,0xc3};

        public static ReadOnlySpan<byte> cell_gᐸ32uᐳᐤuspan32uㆍ32iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x49,0x63,0xd0,0x48,0x8d,0x04,0x90,0xc3};

        public static ReadOnlySpan<byte> cell_gᐸ64uᐳᐤuspan64uㆍ32iᐤ  =>  new byte[16]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x49,0x63,0xd0,0x48,0x8d,0x04,0xd0,0xc3};

        public static ReadOnlySpan<byte> cell_gᐸ8uᐳᐤuspanMemRefㆍMemStoreIndexㆍ32iᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x8b,0x02,0x41,0x0f,0xb6,0xd0,0x48,0x63,0xd2,0x48,0xc1,0xe2,0x04,0x48,0x03,0xc2,0xc5,0xf9,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0x49,0x63,0xd1,0x48,0x03,0xc2,0xc3};

        public static ReadOnlySpan<byte> cell_gᐸ16uᐳᐤuspanMemRefㆍMemStoreIndexㆍ32iᐤ  =>  new byte[39]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x8b,0x02,0x41,0x0f,0xb6,0xd0,0x48,0x63,0xd2,0x48,0xc1,0xe2,0x04,0x48,0x03,0xc2,0xc5,0xf9,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0x49,0x63,0xd1,0x48,0x8d,0x04,0x50,0xc3};

        public static ReadOnlySpan<byte> cell_gᐸ32uᐳᐤuspanMemRefㆍMemStoreIndexㆍ32iᐤ  =>  new byte[39]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x8b,0x02,0x41,0x0f,0xb6,0xd0,0x48,0x63,0xd2,0x48,0xc1,0xe2,0x04,0x48,0x03,0xc2,0xc5,0xf9,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0x49,0x63,0xd1,0x48,0x8d,0x04,0x90,0xc3};

        public static ReadOnlySpan<byte> cell_gᐸ64uᐳᐤuspanMemRefㆍMemStoreIndexㆍ32iᐤ  =>  new byte[39]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x8b,0x02,0x41,0x0f,0xb6,0xd0,0x48,0x63,0xd2,0x48,0xc1,0xe2,0x04,0x48,0x03,0xc2,0xc5,0xf9,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0x49,0x63,0xd1,0x48,0x8d,0x04,0xd0,0xc3};

        public static ReadOnlySpan<byte> load_ᐤMemRefᕀinᐤ  =>  new byte[33]{0xc5,0xf8,0x77,0x66,0x90,0xc4,0xc1,0x79,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0xc4,0xe3,0xf9,0x16,0xc1,0x01,0x8b,0xc9,0x48,0x89,0x02,0x89,0x4a,0x08,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> load_ᐤuspanMemRefㆍMemStoreIndexᐤ  =>  new byte[49]{0xc5,0xf8,0x77,0x66,0x90,0x49,0x8b,0x00,0x41,0x0f,0xb6,0xc9,0x48,0x63,0xc9,0x48,0xc1,0xe1,0x04,0x48,0x03,0xc1,0xc5,0xf9,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0xc4,0xe3,0xf9,0x16,0xc1,0x01,0x8b,0xc9,0x48,0x89,0x02,0x89,0x4a,0x08,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> cell_ᐤuspanMemRefㆍMemStoreIndexㆍ32iᐤ  =>  new byte[38]{0xc5,0xf8,0x77,0x66,0x90,0x48,0x8b,0x02,0x41,0x0f,0xb6,0xd0,0x48,0x63,0xd2,0x48,0xc1,0xe2,0x04,0x48,0x03,0xc2,0xc5,0xf9,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0x49,0x63,0xd1,0x48,0x03,0xc2,0xc3};

        public static ReadOnlySpan<byte> memref_ᐤuspanMemRefㆍMemStoreIndexᐤ  =>  new byte[23]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0x02,0x41,0x0f,0xb6,0xd0,0x48,0x63,0xd2,0x48,0xc1,0xe2,0x04,0x48,0x03,0xc2,0xc3};

        public static ReadOnlySpan<byte> slice_ᐤuspanMemRefㆍMemStoreIndexㆍ32iᐤ  =>  new byte[65]{0xc5,0xf8,0x77,0x66,0x90,0x8b,0x44,0x24,0x28,0x49,0x8b,0x08,0x45,0x0f,0xb6,0xc1,0x4d,0x63,0xc0,0x49,0xc1,0xe0,0x04,0x49,0x03,0xc8,0xc5,0xf9,0x10,0x01,0xc4,0xc1,0xf9,0x7e,0xc0,0xc5,0xf9,0x10,0x01,0xc4,0xe3,0xf9,0x16,0xc1,0x01,0x8b,0xc9,0x4c,0x63,0xc8,0x4d,0x03,0xc1,0x2b,0xc8,0x4c,0x89,0x02,0x89,0x4a,0x08,0x48,0x8b,0xc2,0xc3};

        public static ReadOnlySpan<byte> slice_ᐤuspanMemRefㆍMemStoreIndexㆍ32iㆍ32iᐤ  =>  new byte[55]{0xc5,0xf8,0x77,0x66,0x90,0x49,0x8b,0x00,0x41,0x0f,0xb6,0xc9,0x48,0x63,0xc9,0x48,0xc1,0xe1,0x04,0x48,0x03,0xc1,0xc5,0xf9,0x10,0x00,0xc4,0xe1,0xf9,0x7e,0xc0,0x8b,0x4c,0x24,0x28,0x48,0x63,0xc9,0x48,0x03,0xc1,0x8b,0x4c,0x24,0x30,0x48,0x89,0x02,0x89,0x4a,0x08,0x48,0x8b,0xc2,0xc3};

    }
}
