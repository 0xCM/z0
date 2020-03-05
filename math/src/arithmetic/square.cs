//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;        
    
    partial class math
    {
        [MethodImpl(Inline), Op]
        public static sbyte square(sbyte src)
            => mul(src,src);

        [MethodImpl(Inline), Op]
        public static byte square(byte src)
            => mul(src,src);

        [MethodImpl(Inline), Op]
        public static short square(short src)
            => mul(src,src);

        [MethodImpl(Inline), Op]
        public static ushort square(ushort src)
            => mul(src,src);

        [MethodImpl(Inline), Op]
        public static int square(int src)
            => src*src;

        [MethodImpl(Inline), Op]
        public static uint square(uint src)
            => src*src;

        [MethodImpl(Inline), Op]
        public static long square(long src)
            => src*src;

        [MethodImpl(Inline), Op]
        public static ulong square(ulong src)
            => src*src;                 
    }
}