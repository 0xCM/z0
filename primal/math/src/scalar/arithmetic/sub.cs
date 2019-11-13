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
        public static sbyte sub(sbyte a, sbyte b)
            => (sbyte)(a - b);

        [MethodImpl(Inline)]
        public static byte sub(byte a, byte b)
            => (byte)(a - b);

        [MethodImpl(Inline)]
        public static short sub(short a, short b)
            => (short)(a - b);

        [MethodImpl(Inline)]
        public static ushort sub(ushort a, ushort b)
            => (ushort)(a - b);

        [MethodImpl(Inline)]
        public static int sub(int a, int b)
            => a - b;

        [MethodImpl(Inline)]
        public static uint sub(uint a, uint b)
            => a - b;

        [MethodImpl(Inline)]
        public static long sub(long a, long b)
            => a - b;

        [MethodImpl(Inline)]
        public static ulong sub(ulong a, ulong b)
            => a - b;

        [MethodImpl(Inline)]
        public static ref sbyte sub(ref sbyte a, sbyte b)
        {
            a -= b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref byte sub(ref byte a, byte b)
        {
            a -= b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref short sub(ref short a, short b)
        {
            a -= b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ushort sub(ref ushort a, ushort b)
        {
            a -= b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref int sub(ref int a, int b)
        {
            a -= b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref uint sub(ref uint a, uint b)
        {
            a -= b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref long sub(ref long a, long b)
        {
            a -= b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ulong sub(ref ulong a, ulong b)
        {
            a -= b;
            return ref a;
        }
    }
}