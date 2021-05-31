//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static math;

    partial struct BitFields
    {
        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static ref Bitfield8<T> store<T>(byte i0, byte i1, T src, ref Bitfield8<T> dst)
            where T : unmanaged
        {
            dst.Overwrite(or(dst.State, sll(u8(src), u8(i1 - i0 + 1))));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(UInt8x16k)]
        public static ref Bitfield16<T> store<T>(byte i0, byte i1, T src, ref Bitfield16<T> dst)
            where T : unmanaged
        {
            dst.Overwrite(or(dst.State, sll(u16(src), u8(i1 - i0 + 1))));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static ref Bitfield32<T> store<T>(byte i0, byte i1, T src, ref Bitfield32<T> dst)
            where T : unmanaged
        {
            dst.Overwrite(or(dst.State, sll(u32(src), u8(i1 - i0 + 1))));
            return ref dst;
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ref Bitfield64<T> store<T>(byte i0, byte i1, T src, ref Bitfield64<T> dst)
            where T : unmanaged
        {
            dst.Overwrite(or(dst.State, sll(u64(src), u8(i1 - i0 + 1))));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Bitfield32 store(byte i0, byte i1, uint src, ref Bitfield32 dst)
        {
            dst.Overwrite(or(dst.State, sll(src, u8(i1 - i0 + 1))));
            return ref dst;
        }

        [MethodImpl(Inline), Op]
        public static ref Bitfield64 store(byte i0, byte i1, ulong src, ref Bitfield64 dst)
        {
            dst.Overwrite(or(dst.State, sll(src, u8(i1 - i0 + 1))));
            return ref dst;
        }
    }
}