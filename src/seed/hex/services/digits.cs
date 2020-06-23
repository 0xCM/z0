//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;
    using static As;
    using static HexSpecs;

    partial class Hex
    {
        [MethodImpl(Inline), Op]
        public static void digits(byte value, out char d0, out char d1)
        {
            ref readonly var codes = ref head(Uppercase);
            d0 = (char)skip(in codes, 0xF & value);
            d1 = (char)skip(in codes, (value >> 4) & 0xF);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ReadOnlySpan<char> digits<T>(T value)
            where T : unmanaged
                => digits_u(value);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void digits<T>(T value, Span<char> dst, int offset)
            where T : unmanaged
                => digits_u(value, dst, offset);

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits_u<T>(T value)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return digits(uint8(value));
            else if(typeof(T) == typeof(ushort))
                return digits(int16(value));
            else if(typeof(T) == typeof(uint))
                return digits(uint32(value));
            else if(typeof(T) == typeof(ulong))
                return digits(uint64(value));
            else
                return digits_i(value);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits_i<T>(T value)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return digits(int8(value));
            else if(typeof(T) == typeof(short))
                return digits(int16(value));
            else if(typeof(T) == typeof(int))
                return digits(int32(value));
            else if(typeof(T) == typeof(long))
                return digits(int64(value));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static void digits_u<T>(T value, Span<char> dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                digits(uint8(value), dst, offset);
            else if(typeof(T) == typeof(ushort))
                digits(uint16(value), dst, offset);
            else if(typeof(T) == typeof(uint))
                digits(uint32(value), dst, offset);
            else if(typeof(T) == typeof(ulong))
                digits(uint64(value), dst, offset);
            else
                digits_i(value,dst,offset);
        }

        [MethodImpl(Inline)]
        static void digits_i<T>(T value, Span<char> dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                digits(int8(value), dst, offset);
            else if(typeof(T) == typeof(short))
                digits(int16(value), dst, offset);
            else if(typeof(T) == typeof(int))
                digits(int32(value), dst, offset);
            else if(typeof(T) == typeof(long))
                digits(int64(value), dst, offset);
            else
                throw Unsupported.define<T>();
        }

        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(byte src)
        {
            ref readonly var codes = ref head(Uppercase);
            var storage = Stacks.char2();
            ref var dst = ref storage.C0;
            
            seek(ref dst,0) = (char)skip(in codes, 0xF & src);
            seek(ref dst,1) = (char)skip(in codes, (src >> 4) & 0xF);
            return Stacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 2-character hex representation of a signed byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(sbyte src)
            => digits((byte)src);

        /// <summary>
        /// Computes the 4-character hex representation of an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(ushort src)
        {
            const int count = 4;
            ref readonly var codes = ref head(Uppercase);
            var storage = Stacks.char4();
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                Stacks.cell(ref dst, i) = (char)skip(in codes, (src >> i*4) & 0xF);
            return Stacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 4-character hex representation of a signed 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(short src)
            => digits((ushort)src);

        /// <summary>
        /// Computes the 8-character hex representation of an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(uint src)
        {
            const int count = 8;
            ref readonly var codes = ref head(Uppercase);
            var storage = Stacks.char8();
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                Stacks.cell(ref dst, i) = (char)skip(in codes, (int) ((src >> i*4) & 0xF));
            return Stacks.span(ref storage);
        }

        /// <summary>
        /// Computes the 8-character hex representation of a signed 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(int src)
            => digits((uint)src);

        /// <summary>
        /// Computes the 16-character hex representation of an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(ulong src)
        {
            const int count = 16;
            ref readonly var codes = ref head(Uppercase);
            var storage = Stacks.char16();
            ref var dst = ref storage.C0;

            for(var i=0; i < count; i++)
                Stacks.cell(ref dst, i) = (char)skip(in codes, (int) ((src >> i*4) & 0xF));
            return Stacks.span(ref storage);
        }               

        /// <summary>
        /// Computes the 16-character hex representation of a signed 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline)]
        static ReadOnlySpan<char> digits(long src)
            => digits((ulong)src);

        [MethodImpl(Inline)]
        static void digits(byte src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref head(Uppercase);
            ref var target = ref head(dst);
            
            seek(ref target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(ref target, offset + 1) = (char)skip(in codes, (src >> 4) & 0xF);            
        }

        [MethodImpl(Inline)]
        static void digits(sbyte src, Span<char> dst, int offset)
            => digits((byte)src,dst,offset);
        
        [MethodImpl(Inline)]
        static void digits(ushort src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref head(Uppercase);
            ref var target = ref head(dst);
            seek(ref target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(ref target, offset + 1) = (char)skip(in codes, (src >> 1*4) & 0xF);            
            seek(ref target, offset + 2) = (char)skip(in codes, (src >> 2*4) & 0xF);            
            seek(ref target, offset + 3) = (char)skip(in codes, (src >> 3*4) & 0xF);            
        }

        [MethodImpl(Inline)]
        static void digits(short src, Span<char> dst, int offset)
            => digits((ushort)src,dst,offset);

        [MethodImpl(Inline)]
        static void digits(uint src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref head(Uppercase);
            ref var target = ref head(dst);
            seek(ref target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(ref target, offset + 1) = (char)skip(in codes, (src >> 1*4) & 0xF);            
            seek(ref target, offset + 2) = (char)skip(in codes, (src >> 2*4) & 0xF);            
            seek(ref target, offset + 3) = (char)skip(in codes, (src >> 3*4) & 0xF);            
        }

        [MethodImpl(Inline)]
        static void digits(int src, Span<char> dst, int offset)
            => digits((uint)src,dst,offset);

        [MethodImpl(Inline)]
        static void digits(ulong src, Span<char> dst, int offset)
        {
            ref readonly var codes = ref head(Uppercase);
            ref var target = ref head(dst);
            seek(ref target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(ref target, offset + 1) = (char)skip(in codes, (src >> 1*4) & 0xF);            
            seek(ref target, offset + 2) = (char)skip(in codes, (src >> 2*4) & 0xF);            
            seek(ref target, offset + 3) = (char)skip(in codes, (src >> 3*4) & 0xF);            
            seek(ref target, offset + 4) = (char)skip(in codes, (src >> 4*4) & 0xF);            
            seek(ref target, offset + 5) = (char)skip(in codes, (src >> 5*4) & 0xF);            
            seek(ref target, offset + 6) = (char)skip(in codes, (src >> 6*4) & 0xF);            
            seek(ref target, offset + 7) = (char)skip(in codes, (src >> 7*4) & 0xF);            
        }

        [MethodImpl(Inline)]
        static void digits(long src, Span<char> dst, int offset)
            => digits((ulong)src,dst,offset);
    }
}