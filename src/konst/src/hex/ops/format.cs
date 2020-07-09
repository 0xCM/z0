//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Typed;
    using static core;
 
    partial class Hex
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static string format<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
                => format_u(src,zpad, specifier, uppercase,prespec);

        [MethodImpl(Inline)]
        static string format_u<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return uint8(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(ushort))
                return uint16(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(uint))
                return uint32(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(ulong))
                return uint64(src).FormatHex(zpad, specifier, uppercase, prespec);
            else
                return format_i(src,zpad,specifier,uppercase,prespec);
        } 

        [MethodImpl(Inline)]
        static string format_i<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return int8(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(short))
                return int16(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(int))
                return int32(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(long))
                return int64(src).FormatHex(zpad, specifier, uppercase, prespec);
            else
                return format_f(src,zpad,specifier,uppercase,prespec);
        } 

        [MethodImpl(Inline)]
        static string format_f<T>(T src, bool zpad = true, bool specifier = true, bool uppercase = false, bool prespec = true)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return float32(src).FormatHex(zpad, specifier, uppercase, prespec);
            else if(typeof(T) == typeof(double))
                return float64(src).FormatHex(zpad, specifier, uppercase, prespec);
            else
                throw Unsupported.define<T>();
        } 
 
        [MethodImpl(Inline), Op]
        public static string format<W,T>(T value, W w = default)
            where W : unmanaged, IDataWidth
            where T : unmanaged
        {
            if(typeof(W) == typeof(W8))
                return SmallHexFormat.format(Cast.to<T,byte>(value));
            else if(typeof(W) == typeof(W16))
                return SmallHexFormat.format(Cast.to<T,ushort>(value));
            else if(typeof(W) == typeof(W32))
                return SmallHexFormat.format(Cast.to<T,uint>(value));
            else if(typeof(W) == typeof(W64))
                return SmallHexFormat.format(Cast.to<T,ulong>(value));
            else
                return default;
        }        

        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex1Kind> src, Hex1Kind kind)
            => src.String(kind);        

        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex2Kind> src,  Hex2Kind kind)
            => src.String(kind);        

        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex3Kind> src, Hex3Kind kind)
            => src.String(kind);
        
        [MethodImpl(Inline), Op]
        public static string format(in HexText<Hex4Kind> src, Hex4Kind kind)        
            => src.String(kind);

        [MethodImpl(Inline), Op]
        public static string format(Hex1Kind kind)
            => format(text(n1), kind);        

        [MethodImpl(Inline), Op]
        public static string format(Hex2Kind kind)
            => format(text(n2), kind);        

        [MethodImpl(Inline), Op]
        public static string format(Hex3Kind kind)
            => format(text(n3), kind);        
        
        [MethodImpl(Inline), Op]
        public static string format(Hex4Kind kind)        
            => format(text(n4), kind);        
    }
}