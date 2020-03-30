//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    public static partial class Widths
    {        
        public static W1 w1 => default(W1);

        public static W8 w8 => default(W8);

        public static W16 w16 => default(W16);

        public static W32 w32 => default(W32);

        public static W64 w64 => default(W64);

        public static W128 w128 => default(W128);

        public static W256 w256 => default(W256);

        public static W512 w512 => default(W512);

        public static W1024 w1024 => default(W1024);


        [MethodImpl(Inline)]
        public static ushort value<W>()
            where W : unmanaged, ITypeWidth
        {
            if(typeof(W) == typeof(W8))
                return 8;
            else if(typeof(W) == typeof(W16))
                return 16;
            else if(typeof(W) == typeof(W32))
                return 32;
            else if(typeof(W) == typeof(W64))
                return 64;
            else if(typeof(W) == typeof(W128))
                return 128;
            else if(typeof(W) == typeof(W256))
                return 256;
            else if(typeof(W) == typeof(W512))
                return 512;
            else if(typeof(W) == typeof(W1024))
                return 1024;
            else
                throw new Exception("");
        }
    }
}