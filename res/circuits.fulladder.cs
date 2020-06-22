//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.ByteCode
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static class circuits_fulladder
    {
        public static ReadOnlySpan<byte> Compute_gᐸ8uᐳᐤ8uㆍ8uㆍ8uㆍ8uᕀoutㆍ8uᕀoutᐤ  =>  new byte[66]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb6,0xc1,0x44,0x0f,0xb6,0xd2,0x41,0x33,0xc2,0x0f,0xb6,0xc0,0x45,0x0f,0xb6,0xd0,0x44,0x23,0xd0,0x45,0x0f,0xb6,0xd2,0x0f,0xb6,0xc9,0x0f,0xb6,0xd2,0x23,0xd1,0x0f,0xb6,0xd2,0x41,0x0f,0xb6,0xc8,0x33,0xc1,0x0f,0xb6,0xc0,0x41,0x88,0x01,0x41,0x0b,0xd2,0x0f,0xb6,0xc2,0x48,0x8b,0x54,0x24,0x28,0x88,0x02,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ16uᐳᐤ16uㆍ16uㆍ16uㆍ16uᕀoutㆍ16uᕀoutᐤ  =>  new byte[68]{0x0f,0x1f,0x44,0x00,0x00,0x0f,0xb7,0xc1,0x44,0x0f,0xb7,0xd2,0x41,0x33,0xc2,0x0f,0xb7,0xc0,0x45,0x0f,0xb7,0xd0,0x44,0x23,0xd0,0x45,0x0f,0xb7,0xd2,0x0f,0xb7,0xc9,0x0f,0xb7,0xd2,0x23,0xd1,0x0f,0xb7,0xd2,0x41,0x0f,0xb7,0xc8,0x33,0xc1,0x0f,0xb7,0xc0,0x66,0x41,0x89,0x01,0x41,0x0b,0xd2,0x0f,0xb7,0xc2,0x48,0x8b,0x54,0x24,0x28,0x66,0x89,0x02,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ32uᐳᐤ32uㆍ32uㆍ32uㆍ32uᕀoutㆍ32uᕀoutᐤ  =>  new byte[34]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x33,0xc2,0x44,0x8b,0xd0,0x45,0x23,0xd0,0x23,0xd1,0x41,0x33,0xc0,0x41,0x89,0x01,0x41,0x0b,0xd2,0x48,0x8b,0x44,0x24,0x28,0x89,0x10,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ64uᐳᐤ64uㆍ64uㆍ64uㆍ64uᕀoutㆍ64uᕀoutᐤ  =>  new byte[38]{0x0f,0x1f,0x44,0x00,0x00,0x48,0x8b,0xc1,0x48,0x33,0xc2,0x4c,0x8b,0xd0,0x4d,0x23,0xd0,0x48,0x23,0xd1,0x49,0x33,0xc0,0x49,0x89,0x01,0x49,0x0b,0xd2,0x48,0x8b,0x44,0x24,0x28,0x48,0x89,0x10,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ8uᐳᐤv256x8uㆍv256x8uㆍv256x8uㆍv256x8uᕀoutㆍv256x8uᕀoutᐤ  =>  new byte[73]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x01,0xc5,0xfd,0x10,0x0a,0xc5,0xfd,0xef,0xc1,0xc5,0xfc,0x28,0xc8,0xc4,0xc1,0x7d,0x10,0x10,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x10,0x11,0xc5,0xfd,0x10,0x1a,0xc5,0xed,0xdb,0xd3,0xc4,0xc1,0x7d,0x10,0x18,0xc5,0xfd,0xef,0xc3,0xc4,0xc1,0x7d,0x11,0x01,0xc5,0xf5,0xeb,0xc2,0x48,0x8b,0x44,0x24,0x28,0xc5,0xfd,0x11,0x00,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ16uᐳᐤv256x16uㆍv256x16uㆍv256x16uㆍv256x16uᕀoutㆍv256x16uᕀoutᐤ  =>  new byte[73]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x01,0xc5,0xfd,0x10,0x0a,0xc5,0xfd,0xef,0xc1,0xc5,0xfc,0x28,0xc8,0xc4,0xc1,0x7d,0x10,0x10,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x10,0x11,0xc5,0xfd,0x10,0x1a,0xc5,0xed,0xdb,0xd3,0xc4,0xc1,0x7d,0x10,0x18,0xc5,0xfd,0xef,0xc3,0xc4,0xc1,0x7d,0x11,0x01,0xc5,0xf5,0xeb,0xc2,0x48,0x8b,0x44,0x24,0x28,0xc5,0xfd,0x11,0x00,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ32uᐳᐤv256x32uㆍv256x32uㆍv256x32uㆍv256x32uᕀoutㆍv256x32uᕀoutᐤ  =>  new byte[73]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x01,0xc5,0xfd,0x10,0x0a,0xc5,0xfd,0xef,0xc1,0xc5,0xfc,0x28,0xc8,0xc4,0xc1,0x7d,0x10,0x10,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x10,0x11,0xc5,0xfd,0x10,0x1a,0xc5,0xed,0xdb,0xd3,0xc4,0xc1,0x7d,0x10,0x18,0xc5,0xfd,0xef,0xc3,0xc4,0xc1,0x7d,0x11,0x01,0xc5,0xf5,0xeb,0xc2,0x48,0x8b,0x44,0x24,0x28,0xc5,0xfd,0x11,0x00,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ64uᐳᐤv256x64uㆍv256x64uㆍv256x64uㆍv256x64uᕀoutㆍv256x64uᕀoutᐤ  =>  new byte[73]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x01,0xc5,0xfd,0x10,0x0a,0xc5,0xfd,0xef,0xc1,0xc5,0xfc,0x28,0xc8,0xc4,0xc1,0x7d,0x10,0x10,0xc5,0xf5,0xdb,0xca,0xc5,0xfd,0x10,0x11,0xc5,0xfd,0x10,0x1a,0xc5,0xed,0xdb,0xd3,0xc4,0xc1,0x7d,0x10,0x18,0xc5,0xfd,0xef,0xc3,0xc4,0xc1,0x7d,0x11,0x01,0xc5,0xf5,0xeb,0xc2,0x48,0x8b,0x44,0x24,0x28,0xc5,0xfd,0x11,0x00,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ8uᐳᐤv256x8uㆍv256x8uㆍv256x8uᐤ  =>  new byte[71]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc4,0xc1,0x7d,0x10,0x11,0xc5,0xfc,0x28,0xd8,0xc5,0xfc,0x28,0xe1,0xc5,0xe5,0xef,0xdc,0xc5,0xfc,0x28,0xe3,0xc5,0xfc,0x28,0xea,0xc5,0xdd,0xdb,0xe5,0xc5,0xfd,0xdb,0xc1,0xc5,0xe5,0xef,0xca,0xc5,0xdd,0xeb,0xc0,0xc5,0xfd,0x11,0x09,0xc5,0xfd,0x11,0x41,0x20,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ16uᐳᐤv256x16uㆍv256x16uㆍv256x16uᐤ  =>  new byte[71]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc4,0xc1,0x7d,0x10,0x11,0xc5,0xfc,0x28,0xd8,0xc5,0xfc,0x28,0xe1,0xc5,0xe5,0xef,0xdc,0xc5,0xfc,0x28,0xe3,0xc5,0xfc,0x28,0xea,0xc5,0xdd,0xdb,0xe5,0xc5,0xfd,0xdb,0xc1,0xc5,0xe5,0xef,0xca,0xc5,0xdd,0xeb,0xc0,0xc5,0xfd,0x11,0x09,0xc5,0xfd,0x11,0x41,0x20,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ32uᐳᐤv256x32uㆍv256x32uㆍv256x32uᐤ  =>  new byte[71]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc4,0xc1,0x7d,0x10,0x11,0xc5,0xfc,0x28,0xd8,0xc5,0xfc,0x28,0xe1,0xc5,0xe5,0xef,0xdc,0xc5,0xfc,0x28,0xe3,0xc5,0xfc,0x28,0xea,0xc5,0xdd,0xdb,0xe5,0xc5,0xfd,0xdb,0xc1,0xc5,0xe5,0xef,0xca,0xc5,0xdd,0xeb,0xc0,0xc5,0xfd,0x11,0x09,0xc5,0xfd,0x11,0x41,0x20,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ64uᐳᐤv256x64uㆍv256x64uㆍv256x64uᐤ  =>  new byte[71]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xfd,0x10,0x02,0xc4,0xc1,0x7d,0x10,0x08,0xc4,0xc1,0x7d,0x10,0x11,0xc5,0xfc,0x28,0xd8,0xc5,0xfc,0x28,0xe1,0xc5,0xe5,0xef,0xdc,0xc5,0xfc,0x28,0xe3,0xc5,0xfc,0x28,0xea,0xc5,0xdd,0xdb,0xe5,0xc5,0xfd,0xdb,0xc1,0xc5,0xe5,0xef,0xca,0xc5,0xdd,0xeb,0xc0,0xc5,0xfd,0x11,0x09,0xc5,0xfd,0x11,0x41,0x20,0x48,0x8b,0xc1,0xc5,0xf8,0x77,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ8uᐳᐤv128x8uㆍv128x8uㆍv128x8uㆍv128x8uᕀoutㆍv128x8uᕀoutᐤ  =>  new byte[70]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf9,0xef,0xc1,0xc5,0xf8,0x28,0xc8,0xc4,0xc1,0x79,0x10,0x10,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0x10,0x11,0xc5,0xf9,0x10,0x1a,0xc5,0xe9,0xdb,0xd3,0xc4,0xc1,0x79,0x10,0x18,0xc5,0xf9,0xef,0xc3,0xc4,0xc1,0x79,0x11,0x01,0xc5,0xf1,0xeb,0xc2,0x48,0x8b,0x44,0x24,0x28,0xc5,0xf9,0x11,0x00,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ16uᐳᐤv128x16uㆍv128x16uㆍv128x16uㆍv128x16uᕀoutㆍv128x16uᕀoutᐤ  =>  new byte[70]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf9,0xef,0xc1,0xc5,0xf8,0x28,0xc8,0xc4,0xc1,0x79,0x10,0x10,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0x10,0x11,0xc5,0xf9,0x10,0x1a,0xc5,0xe9,0xdb,0xd3,0xc4,0xc1,0x79,0x10,0x18,0xc5,0xf9,0xef,0xc3,0xc4,0xc1,0x79,0x11,0x01,0xc5,0xf1,0xeb,0xc2,0x48,0x8b,0x44,0x24,0x28,0xc5,0xf9,0x11,0x00,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ32uᐳᐤv128x32uㆍv128x32uㆍv128x32uㆍv128x32uᕀoutㆍv128x32uᕀoutᐤ  =>  new byte[70]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf9,0xef,0xc1,0xc5,0xf8,0x28,0xc8,0xc4,0xc1,0x79,0x10,0x10,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0x10,0x11,0xc5,0xf9,0x10,0x1a,0xc5,0xe9,0xdb,0xd3,0xc4,0xc1,0x79,0x10,0x18,0xc5,0xf9,0xef,0xc3,0xc4,0xc1,0x79,0x11,0x01,0xc5,0xf1,0xeb,0xc2,0x48,0x8b,0x44,0x24,0x28,0xc5,0xf9,0x11,0x00,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ64uᐳᐤv128x64uㆍv128x64uㆍv128x64uㆍv128x64uᕀoutㆍv128x64uᕀoutᐤ  =>  new byte[70]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x01,0xc5,0xf9,0x10,0x0a,0xc5,0xf9,0xef,0xc1,0xc5,0xf8,0x28,0xc8,0xc4,0xc1,0x79,0x10,0x10,0xc5,0xf1,0xdb,0xca,0xc5,0xf9,0x10,0x11,0xc5,0xf9,0x10,0x1a,0xc5,0xe9,0xdb,0xd3,0xc4,0xc1,0x79,0x10,0x18,0xc5,0xf9,0xef,0xc3,0xc4,0xc1,0x79,0x11,0x01,0xc5,0xf1,0xeb,0xc2,0x48,0x8b,0x44,0x24,0x28,0xc5,0xf9,0x11,0x00,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ8uᐳᐤv128x8uㆍv128x8uㆍv128x8uᐤ  =>  new byte[68]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc4,0xc1,0x79,0x10,0x11,0xc5,0xf8,0x28,0xd8,0xc5,0xf8,0x28,0xe1,0xc5,0xe1,0xef,0xdc,0xc5,0xf8,0x28,0xe3,0xc5,0xf8,0x28,0xea,0xc5,0xd9,0xdb,0xe5,0xc5,0xf9,0xdb,0xc1,0xc5,0xe1,0xef,0xca,0xc5,0xd9,0xeb,0xc0,0xc5,0xf9,0x11,0x09,0xc5,0xf9,0x11,0x41,0x10,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ16uᐳᐤv128x16uㆍv128x16uㆍv128x16uᐤ  =>  new byte[68]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc4,0xc1,0x79,0x10,0x11,0xc5,0xf8,0x28,0xd8,0xc5,0xf8,0x28,0xe1,0xc5,0xe1,0xef,0xdc,0xc5,0xf8,0x28,0xe3,0xc5,0xf8,0x28,0xea,0xc5,0xd9,0xdb,0xe5,0xc5,0xf9,0xdb,0xc1,0xc5,0xe1,0xef,0xca,0xc5,0xd9,0xeb,0xc0,0xc5,0xf9,0x11,0x09,0xc5,0xf9,0x11,0x41,0x10,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ32uᐳᐤv128x32uㆍv128x32uㆍv128x32uᐤ  =>  new byte[68]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc4,0xc1,0x79,0x10,0x11,0xc5,0xf8,0x28,0xd8,0xc5,0xf8,0x28,0xe1,0xc5,0xe1,0xef,0xdc,0xc5,0xf8,0x28,0xe3,0xc5,0xf8,0x28,0xea,0xc5,0xd9,0xdb,0xe5,0xc5,0xf9,0xdb,0xc1,0xc5,0xe1,0xef,0xca,0xc5,0xd9,0xeb,0xc0,0xc5,0xf9,0x11,0x09,0xc5,0xf9,0x11,0x41,0x10,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> Compute_gᐸ64uᐳᐤv128x64uㆍv128x64uㆍv128x64uᐤ  =>  new byte[68]{0xc5,0xf8,0x77,0x66,0x90,0xc5,0xf9,0x10,0x02,0xc4,0xc1,0x79,0x10,0x08,0xc4,0xc1,0x79,0x10,0x11,0xc5,0xf8,0x28,0xd8,0xc5,0xf8,0x28,0xe1,0xc5,0xe1,0xef,0xdc,0xc5,0xf8,0x28,0xe3,0xc5,0xf8,0x28,0xea,0xc5,0xd9,0xdb,0xe5,0xc5,0xf9,0xdb,0xc1,0xc5,0xe1,0xef,0xca,0xc5,0xd9,0xeb,0xc0,0xc5,0xf9,0x11,0x09,0xc5,0xf9,0x11,0x41,0x10,0x48,0x8b,0xc1,0xc3};

        public static ReadOnlySpan<byte> Compute_ᐤ1uㆍ1uㆍ1uㆍ1uᕀoutㆍ1uᕀoutᐤ  =>  new byte[34]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x33,0xc2,0x44,0x8b,0xd0,0x45,0x23,0xd0,0x23,0xd1,0x41,0x33,0xc0,0x41,0x89,0x01,0x41,0x0b,0xd2,0x48,0x8b,0x44,0x24,0x28,0x89,0x10,0xc3};

        public static ReadOnlySpan<byte> Compute_ᐤ1uㆍ1uㆍ1uᐤ  =>  new byte[91]{0x48,0x83,0xec,0x28,0xc5,0xf8,0x77,0x8b,0xc1,0x33,0xc2,0x44,0x8b,0xc8,0x45,0x23,0xc8,0x23,0xd1,0x41,0x33,0xc0,0x41,0x0b,0xd1,0x48,0x8d,0x4c,0x24,0x18,0xc5,0xf8,0x57,0xc0,0xc5,0xfa,0x7f,0x01,0x89,0x44,0x24,0x18,0x89,0x54,0x24,0x20,0xc5,0xfa,0x6f,0x44,0x24,0x18,0xc5,0xfa,0x7f,0x44,0x24,0x08,0x33,0xc0,0x89,0x04,0x24,0x89,0x44,0x24,0x04,0x8b,0x44,0x24,0x08,0x8b,0x54,0x24,0x10,0x89,0x04,0x24,0x89,0x54,0x24,0x04,0x48,0x8b,0x04,0x24,0x48,0x83,0xc4,0x28,0xc3};

        public static ReadOnlySpan<byte> Compute_ᐤBitVector32ㆍBitVector32ㆍBitVector32ᐤ  =>  new byte[33]{0x0f,0x1f,0x44,0x00,0x00,0x8b,0xc1,0x33,0xc2,0x44,0x8b,0xc8,0x45,0x23,0xc8,0x23,0xd1,0x41,0x33,0xc0,0x41,0x0b,0xd1,0x48,0xc1,0xe2,0x20,0x8b,0xc0,0x48,0x0b,0xc2,0xc3};

    }
}
