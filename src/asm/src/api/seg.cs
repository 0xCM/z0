//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    using MZ = Asm.MemorySize;
    using SK = SegKind;

    partial struct asm
    {
        [Op]
        public static SegKind seg(MemorySize src)
            => src switch {
                    MZ.UInt8 => SK.Int8u,
                    MZ.UInt16 => SK.Int16u,
                    MZ.UInt32 => SK.Int32u,
                    MZ.UInt64 => SK.Int64u,
                    MZ.Int8 => SK.Int8i,
                    MZ.Int16 => SK.Int16i,
                    MZ.Int32 => SK.Int32i,
                    MZ.Int64 => SK.Int64i,
                    MZ.Float32 => SK.Float32,
                    MZ.Float64 => SK.Float64,
                    MZ.Packed128_Int8 => SK.Seg128x8i,
                    MZ.Packed128_UInt8 => SK.Seg128x8u,
                    MZ.Packed128_Int16 => SK.Seg128x16i,
                    MZ.Packed128_UInt16 =>  SK.Seg128x16u,
                    MZ.Packed128_Int32 => SK.Seg128x32i,
                    MZ.Packed128_UInt32 => SK.Seg128x32u,
                    MZ.Packed128_Int64 => SK.Seg128x64i,
                    MZ.Packed128_UInt64 => SK.Seg128x16u,
                    MZ.Packed128_Float32 => SK.Seg128x32f,
                    MZ.Packed128_Float64 => SK.Seg128x64f,
                    MZ.Packed256_Int8 => SK.Seg256x8i,
                    MZ.Packed256_UInt8 => SK.Seg256x8u,
                    MZ.Packed256_Int16 => SK.Seg256x16i,
                    MZ.Packed256_UInt16 => SK.Seg256x16u,
                    MZ.Packed256_Int32 => SK.Seg256x32i,
                    MZ.Packed256_UInt32 => SK.Seg256x32u,
                    MZ.Packed256_Int64 => SK.Seg256x64i,
                    MZ.Packed256_UInt64 =>  SK.Seg256x64u,
                    MZ.Packed256_Float32 => SK.Seg256x32f,
                    MZ.Packed256_Float64 =>  SK.Seg256x64f,
                _ => SegKind.None
            };


    }

}