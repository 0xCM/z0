//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Widths
    {
        [MethodImpl(Inline)]
        public static string indicator<W>(W w = default)
            where W : unmanaged, IDataWidth
                => indicator<W>(W1.W);

        [MethodImpl(Inline)]
        static string indicator<W>(W1 first)
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
                return indicator<W>(W8.W);
        }

        [MethodImpl(Inline)]
        static string indicator<W>(W8 first)
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