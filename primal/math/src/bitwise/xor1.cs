//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        [MethodImpl(Inline)]
        public static sbyte xor1(sbyte a)
            => (sbyte)(a ^ byte.MaxValue);

        [MethodImpl(Inline)]
        public static byte xor1(byte a)
            => (byte)(a ^ byte.MaxValue);

        [MethodImpl(Inline)]
        public static short xor1(short a)
            => (short)(a ^ ushort.MaxValue);

        [MethodImpl(Inline)]
        public static ushort xor1(ushort a)
            => (ushort)(a ^ ushort.MaxValue);

        [MethodImpl(Inline)]
        public static int xor1(int a)
            => (int)(a ^ uint.MaxValue);

        [MethodImpl(Inline)]
        public static uint xor1(uint a)
            => a ^ uint.MaxValue;

        [MethodImpl(Inline)]
        public static long xor1(long a)
            =>(long) ((ulong)a ^ ulong.MaxValue);

        [MethodImpl(Inline)]
        public static ulong xor1(ulong a)
            => a ^ ulong.MaxValue;
    }

}