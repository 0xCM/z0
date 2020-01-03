//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;        
    
    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte square(sbyte src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static byte square(byte src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static short square(short src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static ushort square(ushort src)
            => mul(src,src);

        [MethodImpl(Inline)]
        public static int square(int src)
            => src*src;

        [MethodImpl(Inline)]
        public static uint square(uint src)
            => src*src;

        [MethodImpl(Inline)]
        public static long square(long src)
            => src*src;

        [MethodImpl(Inline)]
        public static ulong square(ulong src)
            => src*src;                 
    }
}