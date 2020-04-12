//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    partial class math
    {
        [MethodImpl(Inline), Square]
        public static sbyte square(sbyte src)
            => mul(src,src);

        [MethodImpl(Inline), Square]
        public static byte square(byte src)
            => mul(src,src);

        [MethodImpl(Inline), Square]
        public static short square(short src)
            => mul(src,src);

        [MethodImpl(Inline), Square]
        public static ushort square(ushort src)
            => mul(src,src);

        [MethodImpl(Inline), Square]
        public static int square(int src)
            => src*src;

        [MethodImpl(Inline), Square]
        public static uint square(uint src)
            => src*src;

        [MethodImpl(Inline), Square]
        public static long square(long src)
            => src*src;

        [MethodImpl(Inline), Square]
        public static ulong square(ulong src)
            => src*src;                 
    }
}