//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static Typed;
    using static core;
    using static math;

    [ApiHost]
    public readonly partial struct Bitfields
    {
        const NumericKind Closure = UnsignedInts;

         [MethodImpl(Inline), Op, Closures(Closure)]
         public static T join<T>(BitfieldSeg<T> a, BitfieldSeg<T> b)
            where T : unmanaged
        {
            var dst = gmath.sll(a.State, a.FirstIndex);
            dst = gmath.or(dst, gmath.sll(b.State, b.FirstIndex));
            return dst;
        }

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static Bitfield8<T> create<T>(W8 w, T state)
            where T : unmanaged
                => new Bitfield8<T>(state);

        [MethodImpl(Inline), Op, Closures(UInt8x16k)]
        public static Bitfield16<T> create<T>(W16 w, T state)
            where T : unmanaged
                => new Bitfield16<T>(state);

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield32<T> create<T>(W32 w, T state)
            where T : unmanaged
                => new Bitfield32<T>(state);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Bitfield64<T> create<T>(W64 w, T state)
            where T : unmanaged
                => new Bitfield64<T>(state);

        [MethodImpl(Inline), Op]
        public static Bitfield32 create(uint state)
            => new Bitfield32(state);

        [MethodImpl(Inline), Op]
        public static Bitfield64 create(ulong state)
            => new Bitfield64(state);

        [MethodImpl(Inline), Op]
        public static uint render(Bitfield32 src, Span<char> dst)
        {
            var bytes = src.Bytes;
            var buffer = CharBlock64.Null;
            return BitRender.render(n4, bytes, buffer.Data);
        }

        [MethodImpl(Inline), Op]
        public static uint render(Bitfield64 src, Span<char> dst)
        {
            var bytes = src.Bytes;
            var buffer = CharBlock128.Null;
            return BitRender.render(n4, bytes, buffer.Data);
        }

        [Op]
        public static string format(Bitfield32 src)
        {
            var bytes = src.Bytes;
            var buffer = CharBlock64.Null.Data;
            var count = render(src,buffer);
            var chars = slice(buffer,0,count);
            return text.format(chars);
        }

        [Op]
        public static string format(Bitfield64 src)
        {
            var bytes = src.Bytes;
            var buffer = CharBlock128.Null.Data;
            var count = render(src,buffer);
            var chars = slice(buffer,0,count);
            return text.format(chars);
        }

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield8<T> lo<T>(Bitfield16<T> src)
            where T : unmanaged
                => create(w8, to<T>((byte)src.State));

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield16<T> lo<T>(Bitfield32<T> src)
            where T : unmanaged
                => create(w16, to<T>((ushort)src.State));

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield32<T> lo<T>(Bitfield64<T> src)
            where T : unmanaged
                => create(w32, to<T>((uint)src.State));

        [MethodImpl(Inline), Op]
        public static Bitfield32 lo(Bitfield64 src)
            => create(((uint)src.State));

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield8<T> hi<T>(Bitfield16<T> src)
            where T : unmanaged
                => create(w8, to<T>((byte)(math.srl(src.State,8))));

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield16<T> hi<T>(Bitfield32<T> src)
            where T : unmanaged
                => create(w16, to<T>((ushort)(math.srl(src.State,16))));

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static Bitfield32<T> hi<T>(Bitfield64<T> src)
            where T : unmanaged
                => create(w32, to<T>((uint)(math.srl(src.State, Bitfield32.Width))));

        [MethodImpl(Inline), Op]
        public static Bitfield32 hi(Bitfield64 src)
            => create((uint)(math.srl(src.State, Bitfield32.Width)));

        [MethodImpl(Inline), Op, Closures(UInt8k)]
        public static T read<T>(Bitfield8<T> src, byte i0, byte i1)
            where T : unmanaged
                => @as<T>(Bits.bitseg(src.State, i0, i1));

        [MethodImpl(Inline), Op, Closures(UInt8x16k)]
        public static T read<T>(Bitfield16<T> src, byte i0, byte i1)
            where T : unmanaged
                => @as<T>(Bits.bitseg(src.State, i0, i1));

        [MethodImpl(Inline), Op, Closures(UInt8x16x32k)]
        public static T read<T>(Bitfield32<T> src, byte i0, byte i1)
            where T : unmanaged
                => @as<T>(Bits.bitseg(src.State, i0, i1));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T read<T>(Bitfield64<T> src, byte i0, byte i1)
            where T : unmanaged
                => @as<T>(Bits.bitseg(src.State, i0, i1));

        [MethodImpl(Inline), Op]
        public static uint read(Bitfield32 src, byte i0, byte i1)
            => Bits.bitseg(src.State, i0, i1);

        [MethodImpl(Inline), Op]
        public static ulong read(Bitfield64 src, byte i0, byte i1)
            => Bits.bitseg(src.State, i0, i1);

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

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, int? zpad = null)
            where E : unmanaged, Enum
            where T : unmanaged
                => format<E,T>(src, typeof(E).Name, zpad);

        /// <summary>
        /// Formats a field segments as {typeof(V):Name}:{TrimmedBits}
        /// </summary>
        /// <param name="value">The field value</param>
        /// <typeparam name="E">The field value type</typeparam>
        /// <typeparam name="T">The field data type</typeparam>
        public static string format<E,T>(E src, string name, int? zpad = null)
            where E : unmanaged, Enum
            where T : unmanaged
        {
            var data = Enums.scalar<E,T>(src);
            var limit = (uint)gbits.effwidth(data);
            var config = BitFormat.limited(limit,zpad);
            var formatter = bit.formatter<T>(config);
            return text.concat(name, Chars.Colon, formatter.Format(data));
        }

   }
}