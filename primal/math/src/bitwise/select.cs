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
        //or(and(a, b), and(not(a), c));            
        [MethodImpl(Inline)]
        public static uint select(uint a, uint b, uint c)
            => or(and(a, b), and(not(a), c));            

        [MethodImpl(Inline)]
        public static ulong select(ulong a, ulong b, ulong c)
            => or(and(a, b), and(not(a), c));            //(a & b) | (~a & c);

        [MethodImpl(Inline)]
        public static byte select(byte a, byte b, byte c)
            => (byte)(select((uint)a,(uint)b, (uint)c));

        [MethodImpl(Inline)]
        public static ushort select(ushort a, ushort b, ushort c)
            => (ushort)(select((uint)a,(uint)b, (uint)c));
    }

}