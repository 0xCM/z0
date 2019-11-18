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
        public static byte merge(byte mask, byte a, byte b)
            =>  xor(b, and(xor(b,a), mask));

        [MethodImpl(Inline)]
        public static ushort merge(ushort mask, ushort a, ushort b)
            =>  xor(b, and(xor(b,a), mask));

        [MethodImpl(Inline)]
        public static uint merge(uint mask, uint a, uint b)
            =>  xor(b, and(xor(b,a), mask));
        
        [MethodImpl(Inline)]
        public static ulong merge(ulong mask, ulong a, ulong b)
            =>  xor(b, and(xor(b,a), mask));



    }

}