//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Hex
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<char> chars<T>(T value)
            where T : unmanaged
                => chars_u(value);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static void chars<T>(T value, Span<char> dst, int offset)
            where T : unmanaged
                => chars_u(value, dst, offset);

        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static void chars(byte value, out char d0, out char d1)
        {
            ref readonly var codes = ref first(UpperDigits);
            d0 = (char)skip(codes, (byte)(0xF & value));
            d1 = (char)skip(codes, (byte)((value >> 4) & 0xF));
        }

        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(byte src)
        {
            ref readonly var codes = ref first(UpperDigits);
            var storage = Stacks.char2();
            ref var dst = ref storage.C0;

            seek(dst,0) = (char)skip(codes, (byte)(0xF & src));
            seek(dst,1) = (char)skip(codes, (byte)((src >> 4) & 0xF));
            return Stacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 4-character hex representation of an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(ushort src)
        {
            const int count = 4;
            ref readonly var codes = ref first(UpperDigits);
            var storage = Stacks.char4();
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                Stacks.cell(ref dst, i) = (char)skip(codes, (uint)((src >> i*4) & 0xF));
            return Stacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 8-character hex representation of an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(uint src)
        {
            const int count = 8;
            ref readonly var codes = ref first(UpperDigits);
            var storage = Stacks.char8();
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                Stacks.cell(ref dst, i) = (char)skip(in codes, (uint) ((src >> i*4) & 0xF));
            return Stacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 16-character hex representation of an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(ulong src)
        {
            const int count = 16;
            ref readonly var codes = ref first(UpperDigits);
            var storage = Stacks.char16();
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                Stacks.cell(ref dst, i) = (char)skip(in codes, (uint) ((src >> i*4) & 0xF));
            return Stacks.span(ref storage);
        }

        [MethodImpl(Inline), Op]
        public static void chars(byte src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperDigits);
            ref var target = ref first(dst);

            seek(target, offset + 0) = (char)skip(in codes, (byte)(src & 0xF));
            seek(target, offset + 1) = (char)skip(in codes, (byte)((src >> 4) & 0xF));
        }

        [MethodImpl(Inline), Op]
        public static void chars(ushort src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperDigits);
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, (ushort)(src & 0xF));
            seek(target, offset + 1) = (char)skip(in codes, (ushort)((src >> 1*4) & 0xF));
            seek(target, offset + 2) = (char)skip(in codes, (ushort)((src >> 2*4) & 0xF));
            seek(target, offset + 3) = (char)skip(in codes, (ushort)((src >> 3*4) & 0xF));
        }

        [MethodImpl(Inline), Op]
        public static void chars(uint src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperDigits);
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(target, offset + 1) = (char)skip(in codes, (src >> 1*4) & 0xF);
            seek(target, offset + 2) = (char)skip(in codes, (src >> 2*4) & 0xF);
            seek(target, offset + 3) = (char)skip(in codes, (src >> 3*4) & 0xF);
        }

        [MethodImpl(Inline), Op]
        public static void chars(ulong src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperDigits);
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(target, offset + 1) = (char)skip(in codes, (src >> 1*4) & 0xF);
            seek(target, offset + 2) = (char)skip(in codes, (src >> 2*4) & 0xF);
            seek(target, offset + 3) = (char)skip(in codes, (src >> 3*4) & 0xF);
            seek(target, offset + 4) = (char)skip(in codes, (src >> 4*4) & 0xF);
            seek(target, offset + 5) = (char)skip(in codes, (src >> 5*4) & 0xF);
            seek(target, offset + 6) = (char)skip(in codes, (src >> 6*4) & 0xF);
            seek(target, offset + 7) = (char)skip(in codes, (src >> 7*4) & 0xF);
        }

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexText<Hex1Seq> src, Hex1Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexText<Hex2Seq> src, Hex2Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexText<Hex3Seq> src, Hex3Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in HexText<Hex4Seq> src, Hex4Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex1Seq kind)
            => chars(text(n1), kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex2Seq kind)
            => chars(text(n2), kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex3Seq kind)
            => chars(text(n3), kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(Hex4Seq kind)
            => chars(text(n4), kind);

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars_u<T>(T value)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return chars(uint8(value));
            else if(typeof(T) == typeof(ushort))
                return chars(int16(value));
            else if(typeof(T) == typeof(uint))
                return chars(uint32(value));
            else if(typeof(T) == typeof(ulong))
                return chars(uint64(value));
            else
                return chars_i(value);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars_i<T>(T value)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return chars(int8(value));
            else if(typeof(T) == typeof(short))
                return chars(int16(value));
            else if(typeof(T) == typeof(int))
                return chars(int32(value));
            else if(typeof(T) == typeof(long))
                return chars(int64(value));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static void chars_u<T>(T value, Span<char> dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                chars(uint8(value), dst, offset);
            else if(typeof(T) == typeof(ushort))
                chars(uint16(value), dst, offset);
            else if(typeof(T) == typeof(uint))
                chars(uint32(value), dst, offset);
            else if(typeof(T) == typeof(ulong))
                chars(uint64(value), dst, offset);
            else
                chars_i(value,dst,offset);
        }

        [MethodImpl(Inline)]
        static void chars_i<T>(T value, Span<char> dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                chars(int8(value), dst, offset);
            else if(typeof(T) == typeof(short))
                chars(int16(value), dst, offset);
            else if(typeof(T) == typeof(int))
                chars(int32(value), dst, offset);
            else if(typeof(T) == typeof(long))
                chars(int64(value), dst, offset);
            else
                throw Unsupported.define<T>();
        }
    }
}