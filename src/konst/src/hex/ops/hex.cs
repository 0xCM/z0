//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static core;
    using static HexSpecs;

    partial class Hex
    {
        /// <summary>
        /// Presents the source value as a sequence of hex symbols
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="case">The case selector</param>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<HexSym> hex<C>(byte src, C @case = default)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return core.recover<char,HexSym>(span(src.ToString(LC)));
            else
                return core.recover<char,HexSym>(span(src.ToString(UC)));
        }

        [MethodImpl(Inline)]
        public static char hex<T,C>(T src, byte pos, C @case = default)
            where T : unmanaged
            where C : unmanaged, ILetterCase
        {
            if(typeof(T) == typeof(byte))
                return hex(uint8(src), pos, @case);
            else if(typeof(T) == typeof(ushort))
                return hex(uint16(src), pos, @case);
            else if(typeof(T) == typeof(uint))
                return hex(uint32(src), pos, @case);
            else if(typeof(T) == typeof(ulong))
                return hex(uint64(src), pos, @case);
            else 
                return default;
        }
        
        [MethodImpl(Inline)]
        public static char hex<C>(byte src, byte pos, C @case = default)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hex(src, pos, LowerCase);
            else
                return hex(src, pos, UpperCase);            
        }

        [MethodImpl(Inline)]
        public static char hex<C>(ushort src, byte pos, C @case = default)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hex(src, pos, LowerCase);
            else
                return hex(src, pos, UpperCase);            
        }

        [MethodImpl(Inline)]
        public static char hex<C>(uint src, byte pos, C @case = default)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hex(src, pos, LowerCase);
            else
                return hex(src, pos, UpperCase);            
        }

        [MethodImpl(Inline)]
        public static char hex<C>(ulong src, byte pos, C @case = default)
            where C : unmanaged, ILetterCase
        {
            if(typeof(C) == typeof(LowerCased))
                return hex(src, pos, LowerCase);
            else
                return hex(src, pos, UpperCase);            
        }

        [MethodImpl(Inline), Op]
        public static char hex(byte value, byte pos)
            => (char)skip(first(UpperDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hex(ushort value, byte pos)
            => (char)skip(first(UpperDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hex(uint value, byte pos)
            => (char)skip(first(UpperDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hex(ulong value, byte pos)
            => (char)skip(first(UpperDigits), (byte)(0xF & (byte)(value >> pos*4)));        

        [MethodImpl(Inline), Op]
        public static char hex(byte value, byte pos, LowerCased @case)
            => (char)skip(first(LowerDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hex(ushort value, byte pos, LowerCased @case)
            => (char)skip(first(LowerDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hex(uint value, byte pos, LowerCased @case)
            => (char)skip(first(LowerDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hex(ulong value, byte pos, LowerCased @case)
            => (char)skip(first(LowerDigits), (byte)(0xF & (byte)(value >> pos*4)));        

        [MethodImpl(Inline), Op]
        public static char hex(byte value, byte pos, UpperCased @case)
            => (char)skip(first(UpperDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hex(ushort value, byte pos, UpperCased @case)
            => (char)skip(first(UpperDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hex(uint value, byte pos, UpperCased @case)
            => (char)skip(first(UpperDigits), (byte)(0xF & (byte)(value >> pos*4)));

        [MethodImpl(Inline), Op]
        public static char hex(ulong value, byte pos, UpperCased @case)
            => (char)skip(first(UpperDigits), (byte)(0xF & (byte)(value >> pos*4)));        
    }
}