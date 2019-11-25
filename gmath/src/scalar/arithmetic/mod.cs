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
        public static sbyte mod(sbyte a, sbyte b)
            => (sbyte)(a % b);

        [MethodImpl(Inline)]
        public static byte mod(byte a, byte b)
            => (byte)(a % b);

        [MethodImpl(Inline)]
        public static short mod(short a, short b)
            => (short)(a % b);

        [MethodImpl(Inline)]
        public static ushort mod(ushort a, ushort b)
            => (ushort)(a % b);

        [MethodImpl(Inline)]
        public static int mod(int a, int b)
            => a % b;

        [MethodImpl(Inline)]
        public static uint mod(uint a, uint b)
            => a % b;

        [MethodImpl(Inline)]
        public static long mod(long a, long b)
            => a % b;

        [MethodImpl(Inline)]
        public static ulong mod(ulong a, ulong b)
            => a % b;
    }
}