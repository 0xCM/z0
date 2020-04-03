//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static partial class Widths
    {        
        /// <summary>
        /// Computes the width of a parametrically-identified measurable type
        /// </summary>
        /// <typeparam name="T">The measurable type</typeparam>
        [MethodImpl(Inline)]
        public static TypeWidth measure<T>()
            where T : struct
                =>  (TypeWidth)(Unsafe.SizeOf<T>()*8);
        public static W1 w1 => default(W1);

        public static W8 w8 => default(W8);

        public static W16 w16 => default(W16);

        public static W32 w32 => default(W32);

        public static W64 w64 => default(W64);

        public static W128 w128 => default(W128);

        public static W256 w256 => default(W256);

        public static W512 w512 => default(W512);

        public static W1024 w1024 => default(W1024);

        /// <summary>
        /// Computes the literal width from a parametric width
        /// </summary>
        /// <typeparam name="W">The parametric width</typeparam>
        [MethodImpl(Inline)]
        public static TypeWidth literal<W>()
            where W : unmanaged, ITypeWidth
        {
            if(typeof(W) == typeof(W8))
                return TypeWidth.W8;
            else if(typeof(W) == typeof(W16))
                return TypeWidth.W16;
            else if(typeof(W) == typeof(W32))
                return TypeWidth.W32;
            else if(typeof(W) == typeof(W64))
                return TypeWidth.W64;
            else if(typeof(W) == typeof(W128))
                return TypeWidth.W128;
            else if(typeof(W) == typeof(W256))
                return TypeWidth.W256;
            else if(typeof(W) == typeof(W512))
                return TypeWidth.W512;
            else if(typeof(W) == typeof(W1024))
                return TypeWidth.W1024;
            else
                return 0;
        }
    }
}