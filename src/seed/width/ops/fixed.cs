//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    using K = FixedWidth;

    partial class Widths
    {        
        /// <summary>
        /// Determines the attributed width of a fixed type
        /// </summary>
        /// <param name="src">The source type</param>
        public static TypeWidth tfixed(Type src)
            => src.Tag<FixedAttribute>().MapValueOrDefault(a =>a.TypeWidth, TypeWidth.None);

        [MethodImpl(Inline)]
        public static FixedWidth tfixed<W>(W w = default)
            where W : struct, IFixedWidth
        {
            if(typeof(W) == typeof(W16))
                return K.W16;
            else if(typeof(W) == typeof(W32))
                return K.W32;
            else if(typeof(W) == typeof(W64))
                return K.W64;
            else if(typeof(W) == typeof(W128))
                return K.W128;
            else if(typeof(W) == typeof(W256))
                return K.W256;
            else if(typeof(W) == typeof(W512))
                return K.W512;
            else
                return 0;
        }

    }
}