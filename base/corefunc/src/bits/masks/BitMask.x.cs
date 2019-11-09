//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static class BitMaskX
    {
        [MethodImpl(Inline)]
        public static byte ToScalar(this BitMask8 src)
            => (byte)src;

        [MethodImpl(Inline)]
        public static ushort ToScalar(this BitMask16 src)
            => (ushort)src;

        [MethodImpl(Inline)]
        public static uint ToScalar(this BitMask32 src)
            => (uint)src;

        [MethodImpl(Inline)]
        public static ulong ToScalar(this BitMask64 src)
            => (ulong)src;



    }
}