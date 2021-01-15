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
    using static HexFormatSpecs;

    partial class Hex
    {
        /// <summary>
        /// Computes the 2-character hex representation of a signed byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(sbyte src)
            => chars((byte)src);

        /// <summary>
        /// Computes the 4-character hex representation of a signed 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(short src)
            => chars((ushort)src);

        /// <summary>
        /// Computes the 8-character hex representation of a signed 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(int src)
            => chars((uint)src);

        /// <summary>
        /// Computes the 16-character hex representation of a signed 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(long src)
            => chars((ulong)src);

        [MethodImpl(Inline), Op]
        public static void chars(sbyte src, Span<char> dst, int offset)
            => chars((byte)src,dst,offset);

        [MethodImpl(Inline), Op]
        public static void chars(short src, Span<char> dst, int offset)
            => chars((ushort)src,dst,offset);

        [MethodImpl(Inline), Op]
        public static void chars(int src, Span<char> dst, int offset)
            => chars((uint)src,dst,offset);

        [MethodImpl(Inline), Op]
        public static void chars(long src, Span<char> dst, int offset)
            => chars((ulong)src,dst,offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<char> chars<T>(Base16 @base, UpperCased @case, T value)
            where T : unmanaged
                => chars_u(@base, @case, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void chars<T>(Base16 @base, UpperCased @case, T value, Span<char> dst, int offset)
            where T : unmanaged
                => chars_u(@base, @case, value, dst, offset);

        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static void chars(Base16 @base, UpperCased @case, byte value, out char d0, out char d1)
        {
            ref readonly var codes = ref first(UpperHexDigits);
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
            ref readonly var codes = ref first(UpperHexDigits);
            var storage = MemoryStacks.char2();
            ref var dst = ref storage.C0;

            seek(dst,0) = (char)skip(codes, (byte)(0xF & src));
            seek(dst,1) = (char)skip(codes, (byte)((src >> 4) & 0xF));
            return MemoryStacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 4-character hex representation of an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(ushort src)
        {
            const int count = 4;
            ref readonly var codes = ref first(UpperHexDigits);
            var storage = MemoryStacks.char4();
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                MemoryStacks.cell(ref dst, i) = (char)skip(codes, (uint)((src >> i*4) & 0xF));
            return MemoryStacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 8-character hex representation of an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(uint src)
        {
            const byte count = 8;
            ref readonly var codes = ref first(UpperHexDigits);
            var storage = MemoryStacks.char8();
            ref var dst = ref storage.C0;

            for(byte i=0; i < count; i++)
                MemoryStacks.cell(ref dst, i) = (char)skip(in codes, (uint) ((src >> i*4) & 0xF));
            return MemoryStacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 16-character hex representation of an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(ulong src)
        {
            const byte count = 16;
            ref readonly var codes = ref first(UpperHexDigits);
            var storage = MemoryStacks.char16();
            ref var dst = ref storage.C0;

            for(byte i=0; i<count; i++)
                MemoryStacks.cell(ref dst, i) = (char)skip(in codes, (uint) ((src >> i*4) & 0xF));
            return MemoryStacks.span(ref storage);
        }

        [MethodImpl(Inline), Op]
        public static void chars(byte src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperHexDigits);
            ref var target = ref first(dst);

            seek(target, offset + 0) = (char)skip(in codes, (byte)(src & 0xF));
            seek(target, offset + 1) = (char)skip(in codes, (byte)((src >> 4) & 0xF));
        }

        [MethodImpl(Inline), Op]
        public static void chars(ushort src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperHexDigits);
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, (ushort)(src & 0xF));
            seek(target, offset + 1) = (char)skip(in codes, (ushort)((src >> 1*4) & 0xF));
            seek(target, offset + 2) = (char)skip(in codes, (ushort)((src >> 2*4) & 0xF));
            seek(target, offset + 3) = (char)skip(in codes, (ushort)((src >> 3*4) & 0xF));
        }

        [MethodImpl(Inline), Op]
        public static void chars(uint src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperHexDigits);
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(target, offset + 1) = (char)skip(in codes, (src >> 1*4) & 0xF);
            seek(target, offset + 2) = (char)skip(in codes, (src >> 2*4) & 0xF);
            seek(target, offset + 3) = (char)skip(in codes, (src >> 3*4) & 0xF);
        }

        [MethodImpl(Inline), Op]
        public static void chars(ulong src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref first(UpperHexDigits);
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

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars_u<T>(Base16 @base, UpperCased @case, T value)
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
                return chars_i(@base, @case, value);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars_i<T>(Base16 @base, UpperCased @case, T value)
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
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static void chars_u<T>(Base16 @base, UpperCased @case, T value, Span<char> dst, int offset)
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
                chars_i(@base, @case, value,dst,offset);
        }

        [MethodImpl(Inline)]
        static void chars_i<T>(Base16 @base, UpperCased @case, T value, Span<char> dst, int offset)
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
                throw no<T>();
        }
    }
}