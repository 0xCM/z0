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
    using static HexFormatSpecs;

    partial class Hex
    {
        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<HexSym> hexchar<C>(byte src, C @case = default)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return z.recover<char,HexSym>(span(src.ToString(LC)));
            else
                return z.recover<char,HexSym>(span(src.ToString(UC)));
        }

        [MethodImpl(Inline)]
        public static char hexchar<T,C>(T src, byte pos, C @case = default)
            where T : unmanaged
            where C : unmanaged, ILetterCase
        {
            if(typeof(T) == typeof(byte))
                return hexchar(uint8(src), pos, @case);
            else if(typeof(T) == typeof(ushort))
                return hexchar(uint16(src), pos, @case);
            else if(typeof(T) == typeof(uint))
                return hexchar(uint32(src), pos, @case);
            else if(typeof(T) == typeof(ulong))
                return hexchar(uint64(src), pos, @case);
            else
                return default;
        }

        [MethodImpl(Inline)]
        public static char hexchar<C>(byte src, byte pos, C @case = default)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hexchar(src, pos, LowerCase);
            else
                return hexchar(src, pos, UpperCase);
        }

        [MethodImpl(Inline)]
        public static char hexchar<C>(ushort src, byte pos, C @case = default)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hexchar(src, pos, LowerCase);
            else
                return hexchar(src, pos, UpperCase);
        }

        [MethodImpl(Inline)]
        public static char hexchar<C>(uint src, byte pos, C @case = default)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hexchar(src, pos, LowerCase);
            else
                return hexchar(src, pos, UpperCase);
        }

        [MethodImpl(Inline)]
        public static char hexchar<C>(ulong src, byte pos, C @case = default)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hexchar(src, pos, LowerCase);
            else
                return hexchar(src, pos, UpperCase);
        }

        [MethodImpl(Inline), Op]
        public static char hexchar(byte value, byte pos)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(ushort value, byte pos)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(uint value, byte pos)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(ulong value, byte pos)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(byte value, byte pos, LowerCased @case)
            => (char)skip(first(LowerHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(ushort value, byte pos, LowerCased @case)
            => (char)skip(first(LowerHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(uint value, byte pos, LowerCased @case)
            => (char)skip(first(LowerHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(ulong value, byte pos, LowerCased @case)
            => (char)skip(first(LowerHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(byte value, byte pos, UpperCased @case)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(ushort value, byte pos, UpperCased @case)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(uint value, byte pos, UpperCased @case)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hexchar(ulong value, byte pos, UpperCased @case)
            => (char)skip(first(UpperHexDigits), (byte)(0xF & (byte)(value >> pos*4)));
    }
}