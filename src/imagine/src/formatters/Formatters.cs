//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    [ApiHost]
    public readonly partial struct Formatters
    {        
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
                
        /// <summary>
        /// Reifies a formatter via Object.ToString()
        /// </summary>
        readonly struct DefaultFormatter : IFormatter
        {
            [MethodImpl(Inline)]
            public string Format(object src)
                => src?.ToString() ?? string.Empty;
        }

        [MethodImpl(Inline)]
        public static string specifier<W>(W w = default)
            where W : unmanaged, IDataWidth
                => specifier<W>(W1.W);

        [MethodImpl(Inline)]
        static string specifier<W>(W1 first)
            where W : unmanaged, IDataWidth
        {
            if(typeof(W) == typeof(W1))
                return W1.Identifier;
            else if(typeof(W) == typeof(W2))
                return W2.Identifier;
            else if(typeof(W) == typeof(W3))
                return W3.Identifier;
            else if(typeof(W) == typeof(W4))
                return W4.Identifier;
            else if(typeof(W) == typeof(W5))
                return W5.Identifier;
            else if(typeof(W) == typeof(W6))
                return W6.Identifier;
            else if(typeof(W) == typeof(W7))
                return W7.Identifier;
            else 
                return specifier<W>(W8.W);
        }

        [MethodImpl(Inline)]
        static string specifier<W>(W8 first)
            where W : unmanaged, IDataWidth
        {
            if(typeof(W) == typeof(W8))
                return W8.Identifier;
            else if(typeof(W) == typeof(W16))
                return W16.Identifier;
            else if(typeof(W) == typeof(W32))
                return W32.Identifier;
            else if(typeof(W) == typeof(W64))
                return W64.Identifier;
            else if(typeof(W) == typeof(W128))
                return W128.Identifier;
            else if(typeof(W) == typeof(W256))
                return W256.Identifier;
            else if(typeof(W) == typeof(W512))
                return W512.Identifier;
            else
                return EmptyString;
        }
    }
}