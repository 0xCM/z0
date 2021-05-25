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
    using static Typed;
    using static HexFormatSpecs;

    [ApiHost]
    public readonly struct HexRender
    {
        const NumericKind Closure = Integers;

        public static uint render<N>(HexVector8<N> src, in uint offset, Span<char> dst)
            where N : unmanaged, ITypeNat
        {
            var counter = 0u;
            var @case = LowerCase;
            var count = (int)HexVector8<N>.CellCount;
            seek(dst, counter + offset) = Chars.Lt;
            counter++;
            for(int i=count-1; i>=0; i--)
            {
                ref readonly var cell = ref src[i];
                if(i != count-1)
                    counter += separate(counter + offset, dst);

                counter += render(@case, cell, counter + offset, dst);
            }

            seek(dst, counter + offset) = Chars.Gt;
            counter++;
            return counter;
        }

        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, byte value)
            => (char)Hex.symbol(@case, (HexDigit)value);

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, byte value)
            => (char)Hex.symbol(@case, (HexDigit)value);

        [MethodImpl(Inline)]
        public static char hexchar<C>(C @case, byte value)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hexchar(LowerCase,value);
            else if(typeof(C) == typeof(UpperCased))
                return hexchar(UpperCase,value);
            else
                throw no<C>();
        }

        [MethodImpl(Inline)]
        public static char hexchar<T,C>(C @case, T src, byte pos)
            where T : unmanaged
            where C : unmanaged, ILetterCase
        {
            if(typeof(T) == typeof(byte))
                return hexchar(@case, uint8(src), pos);
            else if(typeof(T) == typeof(ushort))
                return hexchar(@case, uint16(src), pos);
            else if(typeof(T) == typeof(uint))
                return hexchar(@case, uint32(src), pos);
            else if(typeof(T) == typeof(ulong))
                return hexchar(@case, uint64(src), pos);
            else
                return default;
        }

        [MethodImpl(Inline)]
        public static char hexchar<C>(C @case, byte src, byte pos)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hexchar(LowerCase, src, pos);
            else
                return hexchar(UpperCase, src, pos);
        }

        [MethodImpl(Inline)]
        public static char hexchar<C>(C @case, ushort src, byte pos)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hexchar(LowerCase, src, pos);
            else
                return hexchar(UpperCase, src, pos);
        }

        [MethodImpl(Inline)]
        public static char hexchar<C>(C @case, uint src, byte pos)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hexchar(LowerCase, src, pos);
            else
                return hexchar(UpperCase, src, pos);
        }

        [MethodImpl(Inline)]
        public static char hexchar<C>(C @case, ulong src, byte pos)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hexchar(LowerCase, src, pos);
            else
                return hexchar(UpperCase, src, pos);
        }

        /// <summary>
        /// Retrieves the character corresponding to a specified <see cref='HexDigit'/>
        /// </summary>
        /// <param name="case">The case specifier</param>
        /// <param name="value">The digit value</param>
        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, HexDigit value)
            => (char)Hex.symbol(@case, value);

        /// <summary>
        /// Retrieves the character corresponding to a specified <see cref='HexDigit'/>
        /// </summary>
        /// <param name="case">The case specifier</param>
        /// <param name="value">The digit value</param>
        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, HexDigit value)
            => (char)Hex.symbol(@case, value);

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, byte value, byte pos)
            => (char)skip(first(LowerHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, ushort value, byte pos)
            => (char)skip(first(LowerHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, uint value, byte pos)
            => (char)skip(first(LowerHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, ulong value, byte pos)
            => (char)skip(first(LowerHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, byte value, byte pos)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, ushort value, byte pos)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, uint value, byte pos)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, ulong value, byte pos)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));
        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<HexSym> symbols<C>(C @case, byte src)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return recover<char,HexSym>(span(src.ToString(LC)));
            else
                return recover<char,HexSym>(span(src.ToString(UC)));
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void render<T>(in T src, Span<char> dst)
            where T : struct
        {
            var count = size<T>();
            ref readonly var bytes = ref @as<T,byte>(src);
            var j = min(count*2 - 1, dst.Length);
            for(var i=0u; i<count; i++)
            {
                ref readonly var d = ref skip(bytes,i);
                seek(dst, j--) = (char)Hex.code(n4, LowerCase, d);
                seek(dst, j--) = (char)Hex.code(n4, LowerCase, Bytes.srl(d, 4));
            }
        }

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<char> render<T>(Base16 @base, UpperCased @case, T value)
            where T : unmanaged
                => chars_u(@base, @case, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void render<T>(Base16 @base, UpperCased @case, T value, uint offset, Span<char> dst)
            where T : unmanaged
                => chars_u(@base, @case, value, offset, dst);

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars_u<T>(Base16 @base, UpperCased @case, T value)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return render(@case, uint8(value));
            else if(typeof(T) == typeof(ushort))
                return render(@case, int16(value));
            else if(typeof(T) == typeof(uint))
                return render(@case, uint32(value));
            else if(typeof(T) == typeof(ulong))
                return render(@case, uint64(value));
            else
                return chars_i(@base, @case, value);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars_i<T>(Base16 @base, UpperCased @case, T value)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return render(@case, int8(value));
            else if(typeof(T) == typeof(short))
                return render(@case, int16(value));
            else if(typeof(T) == typeof(int))
                return render(@case, int32(value));
            else if(typeof(T) == typeof(long))
                return render(@case, int64(value));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static void chars_u<T>(Base16 @base, UpperCased @case, T value, uint offset, Span<char> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                render(@case, uint8(value), offset, dst);
            else if(typeof(T) == typeof(ushort))
                render(@case, uint16(value), offset, dst);
            else if(typeof(T) == typeof(uint))
                render(@case, uint32(value), offset, dst);
            else if(typeof(T) == typeof(ulong))
                render(@case, uint64(value), offset, dst);
            else
                chars_i(@base, @case, value, offset, dst);
        }

        [MethodImpl(Inline)]
        static void chars_i<T>(Base16 @base, UpperCased @case, T value, uint offset, Span<char> dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                render(@case, int8(value), offset, dst);
            else if(typeof(T) == typeof(short))
                render(@case, int16(value), offset, dst);
            else if(typeof(T) == typeof(int))
                render(@case, int32(value), offset, dst);
            else if(typeof(T) == typeof(long))
                render(@case, int64(value), offset, dst);
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op]
        public static uint render(ReadOnlySpan<HexCode> src, Span<char> dst)
        {
            var j=0u;
            var count = src.Length;
            for(var i=0u; i<count; i+=2, j+=3)
            {
                seek(dst, j) = (char)skip(src, i);
                seek(dst, j + 1) = (char)skip(src, i + 1);
                seek(dst, j + 2) = Chars.Space;
            }

            return j;
        }

        [MethodImpl(Inline), Op]
        public static uint render<C>(C @case, ReadOnlySpan<byte> src, Span<char> dst)
            where C : unmanaged, ILetterCase
        {
            var size = src.Length;
            var j=0u;
            for(var i=0; i<size; i++)
            {
                ref readonly var b = ref skip(src,i);
                seek(dst,j++) = hexchar(@case, b, 0);
                seek(dst,j++) = hexchar(@case, b, 1);
            }
            return j;
        }

        [Op]
        public static uint render(ReadOnlySpan<byte> src, Span<char> dst, bool lower = true)
            => lower ? render(LowerCase,src,dst) : render(UpperCase, src,dst);

        /// <summary>
        /// Formats a span of hex digits as a contiguous block
        /// </summary>
        /// <param name="src">The source digits</param>
        [MethodImpl(Inline)]
        public static uint render<C>(C @case, ReadOnlySpan<HexDigit> src, Span<char> dst)
            where C : unmanaged, ILetterCase
        {
            var count = (uint)src.Length;
            for(var i=0u; i<count; i++)
                seek(dst,i) = (char)Hex.symbol(@case, skip(src,i));
            return count;
        }

        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(UpperCased @case, byte src)
            => chars(first(UpperHexDigits),src);

        /// <summary>
        /// Computes the 2-character hex representation of a byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(LowerCased @case, byte src)
            => chars(first(LowerHexDigits),src);

        /// <summary>
        /// Computes the 2-character hex representation of a signed byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(UpperCased @case, sbyte src)
            => render(@case, (byte)src);

        /// <summary>
        /// Computes the 2-character hex representation of a signed byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(LowerCased @case, sbyte src)
            => render(@case, (byte)src);

        /// <summary>
        /// Computes the 4-character hex representation of a signed 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(UpperCased @case, short src)
            => render(@case, (ushort)src);

        /// <summary>
        /// Computes the 4-character hex representation of a signed 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(LowerCased @case, short src)
            => render(@case, (ushort)src);

        /// <summary>
        /// Computes the 4-character hex representation of an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(UpperCased @case, ushort src)
            => chars(first(UpperHexDigits),src);

        /// <summary>
        /// Computes the 4-character hex representation of an unsigned 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(LowerCased @case, ushort src)
            => chars(first(LowerHexDigits),src);

        /// <summary>
        /// Computes the 8-character hex representation of a signed 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(UpperCased @case, int src)
            => render(@case, (uint)src);

        /// <summary>
        /// Computes the 8-character hex representation of a signed 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(LowerCased @case, int src)
            => render(@case, (uint)src);

        /// <summary>
        /// Computes the 8-character hex representation of an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(UpperCased @case, uint src)
            => chars(first(UpperHexDigits), src);

        /// <summary>
        /// Computes the 8-character hex representation of an unsigned 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(LowerCased @case, uint src)
            => chars(first(LowerHexDigits), src);

        /// <summary>
        /// Computes the 16-character hex representation of a signed 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(UpperCased @case, long src)
            => render(@case, (ulong)src);

        /// <summary>
        /// Computes the 16-character hex representation of a signed 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(LowerCased @case, long src)
            => render(@case, (ulong)src);

        /// <summary>
        /// Computes the 16-character hex representation of an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(UpperCased @case, ulong src)
            => chars(first(UpperHexDigits), src);

        /// <summary>
        /// Computes the 16-character hex representation of an unsigned 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(LowerCased @case, ulong src)
            => chars(first(LowerHexDigits), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(in HexString<Hex1Seq> src, Hex1Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(in HexString<Hex2Seq> src, Hex2Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(in HexString<Hex3Seq> src, Hex3Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(in HexString<Hex4Seq> src, Hex4Seq kind)
            => src.Chars(kind);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(Hex1Seq src)
            => render(Hex.hexstring<Hex1Seq>(), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(Hex2Seq src)
            => render(Hex.hexstring<Hex2Seq>(), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(Hex3Seq src)
            => render(Hex.hexstring<Hex3Seq>(), src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> render(Hex4Seq src)
            => render(Hex.hexstring<Hex4Seq>(), src);

        [MethodImpl(Inline), Op]
        public static uint render(UpperCased @case, byte src, uint offset, Span<char> dst)
            => deposit(first(UpperHexDigits), src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(LowerCased @case, byte src, uint offset, Span<char> dst)
            => deposit(first(LowerHexDigits), src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(UpperCased @case, sbyte src, uint offset, Span<char> dst)
            => render(@case, (byte)src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(LowerCased @case, sbyte src, uint offset, Span<char> dst)
            => render(@case, (byte)src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(UpperCased @case, short src, uint offset, Span<char> dst)
            => render(@case, (ushort)src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(LowerCased @case, short src, uint offset, Span<char> dst)
            => render(@case, (ushort)src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(UpperCased @case, ushort src, uint offset, Span<char> dst)
            => deposit(first(UpperHexDigits), src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(LowerCased @case, ushort src, uint offset, Span<char> dst)
            => deposit(first(LowerHexDigits), src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(UpperCased @case, int src, uint offset, Span<char> dst)
            => render(@case, (uint)src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(LowerCased @case, int src, uint offset, Span<char> dst)
            => render(@case, (uint)src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(UpperCased @case, uint src, uint offset, Span<char> dst)
            => deposit(first(UpperHexDigits), src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(LowerCased @case, uint src, uint offset, Span<char> dst)
            => deposit(first(LowerHexDigits), src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(UpperCased @case, long src, uint offset, Span<char> dst)
            => render(@case, (ulong)src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(LowerCased @case, long src, uint offset, Span<char> dst)
            => render(@case, (ulong)src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(UpperCased @case, ulong src, uint offset, Span<char> dst)
            => deposit(first(UpperHexDigits), src, offset, dst);

        [MethodImpl(Inline), Op]
        public static uint render(LowerCased @case, ulong src, uint offset, Span<char> dst)
            => deposit(first(LowerHexDigits), src, offset, dst);

        [MethodImpl(Inline)]
        static uint deposit(in byte codes, byte src, uint offset, Span<char> dst)
        {
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, (byte)(src & 0xF));
            seek(target, offset + 1) = (char)skip(in codes, (byte)((src >> 4) & 0xF));
            return 2;
        }

        [MethodImpl(Inline)]
        static uint deposit(in byte codes, ushort src, uint offset, Span<char> dst)
        {
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, (ushort)(src & 0xF));
            seek(target, offset + 1) = (char)skip(in codes, (ushort)((src >> 1*4) & 0xF));
            seek(target, offset + 2) = (char)skip(in codes, (ushort)((src >> 2*4) & 0xF));
            seek(target, offset + 3) = (char)skip(in codes, (ushort)((src >> 3*4) & 0xF));
            return 4;
        }

        [MethodImpl(Inline)]
        static uint deposit(in byte codes, uint src, uint offset, Span<char> dst)
        {
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(target, offset + 1) = (char)skip(in codes, (src >> 1*4) & 0xF);
            seek(target, offset + 2) = (char)skip(in codes, (src >> 2*4) & 0xF);
            seek(target, offset + 3) = (char)skip(in codes, (src >> 3*4) & 0xF);
            return 4;
        }

        [MethodImpl(Inline)]
        static uint deposit(in byte codes, ulong src, uint offset, Span<char> dst)
        {
            ref var target = ref first(dst);
            seek(target, offset + 0) = (char)skip(in codes, src & 0xF);
            seek(target, offset + 1) = (char)skip(in codes, (src >> 1*4) & 0xF);
            seek(target, offset + 2) = (char)skip(in codes, (src >> 2*4) & 0xF);
            seek(target, offset + 3) = (char)skip(in codes, (src >> 3*4) & 0xF);
            seek(target, offset + 4) = (char)skip(in codes, (src >> 4*4) & 0xF);
            seek(target, offset + 5) = (char)skip(in codes, (src >> 5*4) & 0xF);
            seek(target, offset + 6) = (char)skip(in codes, (src >> 6*4) & 0xF);
            seek(target, offset + 7) = (char)skip(in codes, (src >> 7*4) & 0xF);
            return 8;
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars(in byte codes, byte src)
        {
            var storage = CharStacks.alloc(n2);
            ref var dst = ref storage.C0;
            seek(dst,0) = (char)skip(codes, (byte)(0xF & src));
            seek(dst,1) = (char)skip(codes, (byte)((src >> 4) & 0xF));
            return CharStacks.span(ref storage);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars(in byte codes, ushort src)
        {
            const int count = 4;
            var storage = CharStacks.alloc(n4);
            ref var dst = ref storage.C0;
            for(var i=0; i<count; i++)
                CharStacks.cell(ref dst, i) = (char)skip(codes, (uint)((src >> i*4) & 0xF));
            return CharStacks.span(ref storage);
        }

        [MethodImpl(Inline), Op]
        static ReadOnlySpan<char> chars(in byte codes, uint src)
        {
            const byte count = 8;
            var storage = CharStacks.alloc(n8);
            ref var dst = ref storage.C0;
            for(byte i=0; i < count; i++)
                CharStacks.cell(ref dst, i) = (char)skip(in codes, (uint) ((src >> i*4) & 0xF));
            return CharStacks.span(ref storage);
        }

        [MethodImpl(Inline)]
        static ReadOnlySpan<char> chars(in byte codes, ulong src)
        {
            const byte count = 16;
            var storage = CharStacks.alloc(n16);
            ref var dst = ref storage.C0;
            for(byte i=0; i<count; i++)
                CharStacks.cell(ref dst, i) = (char)skip(in codes, (uint) ((src >> i*4) & 0xF));
            return CharStacks.span(ref storage);
        }


        [MethodImpl(Inline), Op]
        static uint separate(uint offset, Span<char> dst)
        {
            seek(dst,offset) = Chars.Space;
            return 1;
        }
    }
}