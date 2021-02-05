//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Cells
    {
        [MethodImpl(Inline), Op]
        public static ref Cell8 lo8(ref Cell16 src)
            => ref @as<Cell16,Cell8>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell8 lo8(ref Cell32 src)
            => ref @as<Cell32,Cell8>(src);


        [MethodImpl(Inline), Op]
        public static ref Cell8 lo8(ref Cell128 src)
            => ref @as<Cell128,Cell8>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell8 lo8(ref Cell64 src)
            => ref @as<Cell64,Cell8>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell256 lo256(ref Cell512 src)
            => ref @as<Cell512,Cell256>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell128 lo128(ref Cell512 src)
            => ref @as<Cell512,Cell128>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell64 lo64(ref Cell512 src)
            => ref @as<Cell512,Cell64>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell32 lo32(ref Cell512 src)
            => ref @as<Cell512,Cell32>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell16 lo16(ref Cell512 src)
            => ref @as<Cell512,Cell16>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell8 lo8(ref Cell512 src)
            => ref @as<Cell512,Cell8>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell128 lo128(ref Cell256 src)
            => ref @as<Cell256,Cell128>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell64 lo64(ref Cell256 src)
            => ref @as<Cell256,Cell64>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell32 lo32(ref Cell256 src)
            => ref @as<Cell256,Cell32>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell16 lo16(ref Cell256 src)
            => ref @as<Cell256,Cell16>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell8 lo8(ref Cell256 src)
            => ref @as<Cell256,Cell8>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell64 lo64(ref Cell128 src)
            => ref @as<Cell128,Cell64>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell32 lo32(ref Cell128 src)
            => ref @as<Cell128,Cell32>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell16 lo16(ref Cell128 src)
            => ref @as<Cell128,Cell16>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell32 lo32(ref Cell64 src)
            => ref @as<Cell64,Cell32>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell16 lo16(ref Cell64 src)
            => ref @as<Cell64,Cell16>(src);

        [MethodImpl(Inline), Op]
        public static ref Cell16 lo16(ref Cell32 src)
            => ref @as<Cell32,Cell16>(src);
    }
}