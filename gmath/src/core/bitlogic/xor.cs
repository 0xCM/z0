//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;    

    partial class math
    {

        [MethodImpl(Inline), Op]
        public static sbyte xor(sbyte a, sbyte b)
            => (sbyte)(a ^ b);

        [MethodImpl(Inline), Op]
        public static byte xor(byte a, byte b)
            => (byte)(a ^ b);

        [MethodImpl(Inline), Op]
        public static short xor(short a, short b)
            => (short)(a ^ b);

        [MethodImpl(Inline), Op]
        public static ushort xor(ushort a, ushort b)
            => (ushort)(a ^ b);

        [MethodImpl(Inline), Op]
        public static int xor(int a, int b)
            => a ^ b;

        [MethodImpl(Inline), Op]
        public static uint xor(uint a, uint b)
            => a ^ b;

        [MethodImpl(Inline), Op]
        public static long xor(long a, long b)
            => a ^ b;

        [MethodImpl(Inline), Op]
        public static ulong xor(ulong a, ulong b)
            => a ^ b;
    }
}