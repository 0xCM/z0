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
        public static sbyte div(sbyte a, sbyte b)
            => (sbyte)(a / b);

        [MethodImpl(Inline)]
        public static byte div(byte a, byte b)
            => (byte)(a / b);

        [MethodImpl(Inline)]
        public static short div(short a, short b)
            => (short)(a / b);

        [MethodImpl(Inline)]
        public static ushort div(ushort a, ushort b)
            => (ushort)(a / b);

        [MethodImpl(Inline)]
        public static int div(int a, int b)
            => a / b;

        [MethodImpl(Inline)]
        public static uint div(uint a, uint b)
            => a / b;

        [MethodImpl(Inline)]
        public static long div(long a, long b)
            => a / b;

        [MethodImpl(Inline)]
        public static ulong div(ulong a, ulong b)
            => a / b;

        [MethodImpl(Inline)]
        public static bit divides(sbyte a, sbyte b)
            => b % a == 0;

        [MethodImpl(Inline)]
        public static bit divides(byte a, byte b)
            => b % a == 0;

        [MethodImpl(Inline)]
        public static bit divides(short a, short b)
            => b % a == 0;

        [MethodImpl(Inline)]
        public static bit divides(ushort a, ushort b)
            => b % a == 0;

        [MethodImpl(Inline)]
        public static bit divides(int a, int b)
            => b % a == 0;

        [MethodImpl(Inline)]
        public static bit divides(uint a, uint b)
            => b % a == 0;

        [MethodImpl(Inline)]
        public static bit divides(long a, long b)
            => b % a == 0;

        [MethodImpl(Inline)]
        public static bit divides(ulong a, ulong b)
            => b % a == 0;

   }
}