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

    partial struct Hex
    {
        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, byte value)
            => (char)symbol(@case, (HexDigit)value);

        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, byte value)
            => (char)symbol(@case, (HexDigit)value);

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
                return Hex.hexchar(LowerCase, src, pos);
            else
                return Hex.hexchar(UpperCase, src, pos);
        }

        [MethodImpl(Inline)]
        public static char hexchar<C>(C @case, ushort src, byte pos)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return Hex.hexchar(LowerCase, src, pos);
            else
                return Hex.hexchar(UpperCase, src, pos);
        }

        [MethodImpl(Inline)]
        public static char hexchar<C>(C @case, uint src, byte pos)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return Hex.hexchar(LowerCase, src, pos);
            else
                return Hex.hexchar(UpperCase, src, pos);
        }

        [MethodImpl(Inline)]
        public static char hexchar<C>(C @case, ulong src, byte pos)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return Hex.hexchar(LowerCase, src, pos);
            else
                return Hex.hexchar(UpperCase, src, pos);
        }


        /// <summary>
        /// Retrieves the character corresponding to a specified <see cref='HexDigit'/>
        /// </summary>
        /// <param name="case">The case specifier</param>
        /// <param name="value">The digit value</param>
        [MethodImpl(Inline), Op]
        public static char hexchar(LowerCased @case, HexDigit value)
            => (char)symbol(@case, value);

        /// <summary>
        /// Retrieves the character corresponding to a specified <see cref='HexDigit'/>
        /// </summary>
        /// <param name="case">The case specifier</param>
        /// <param name="value">The digit value</param>
        [MethodImpl(Inline), Op]
        public static char hexchar(UpperCased @case, HexDigit value)
            => (char)symbol(@case, value);

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
    }
}