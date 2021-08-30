//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Blit
    {
        partial struct Types
        {
            [MethodImpl(Inline), Op]
            public static DataType v8(uint n)
                => type(BlittableKind.Vector, n*8, n*8);

            [MethodImpl(Inline), Op]
            public static DataType v16(uint n)
                => type(BlittableKind.Vector, n*16, n*16);

            [MethodImpl(Inline), Op]
            public static DataType v32(uint n)
                => type(BlittableKind.Vector, n*32, n*32);

            [MethodImpl(Inline), Op]
            public static DataType v64(uint n)
                => type(BlittableKind.Vector, n*64, n*64);

            [MethodImpl(Inline), Op]
            public static DataType v128(uint n)
                => type(BlittableKind.Vector, n*128, n*128);

            [MethodImpl(Inline), Op]
            public static DataType v256(uint n)
                => type(BlittableKind.Vector, n*256, n*256);

            [MethodImpl(Inline), Op]
            public static DataType v512(uint n)
                => type(BlittableKind.Vector, n*512, n*512);
        }
    }
}