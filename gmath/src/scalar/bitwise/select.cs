//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public static byte select(byte a, byte b, byte c)
            => or(and(a,b), nonimpl(a,c));

        [MethodImpl(Inline)]
        public static ushort select(ushort a, ushort b, ushort c)
            => or(and(a,b), nonimpl(a,c));

        [MethodImpl(Inline)]
        public static uint select(uint a, uint b, uint c)
            => or(and(a,b), nonimpl(a,c));
        
        [MethodImpl(Inline)]
        public static ulong select(ulong a, ulong b, ulong c)
            => or(and(a,b), nonimpl(a,c)); 

        [MethodImpl(Inline)]
        public static byte blend(byte a, byte b, byte mask)
            =>  xor(a, and(xor(a,b), mask));

        [MethodImpl(Inline)]
        public static ushort blend(ushort a, ushort b, ushort mask)
            =>  xor(a, and(xor(a,b), mask));

        [MethodImpl(Inline)]
        public static uint blend(uint a, uint b, uint mask)
            =>  xor(a, and(xor(a,b), mask));
        
        [MethodImpl(Inline)]
        public static ulong blend(ulong a, ulong b,ulong mask)
            =>  xor(a, and(xor(a,b), mask));

    }

}