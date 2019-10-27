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
        public static sbyte max(sbyte a, sbyte b)
            => a > b ? a : b;

        [MethodImpl(Inline)]
        public static byte max(byte a, byte b)
            => a > b ? a : b;

        [MethodImpl(Inline)]
        public static short max(short a, short b)
            => a > b ? a : b;

        [MethodImpl(Inline)]
        public static ushort max(ushort a, ushort b)
            => a > b ? a : b;

        [MethodImpl(Inline)]
        public static int max(int a, int b)
            => a > b ? a : b;

        [MethodImpl(Inline)]
        public static uint max(uint a, uint b)
            => a > b ? a : b;

        [MethodImpl(Inline)]
        public static long max(long a, long b)
            => a > b ? a : b;

        [MethodImpl(Inline)]
        public static ulong max(ulong a, ulong b)
            => a > b ? a : b;


        [MethodImpl(Inline)]
        public static ref sbyte max(ref sbyte a, sbyte b)
        {
            a = a > b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref byte max(ref byte a, byte b)
        {
            a = a > b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref short max(ref short a, short b)
        {
            a = a > b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ushort max(ref ushort a, ushort b)
        {
            a = a > b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref int max(ref int a, int b)
        {
            a = a > b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref uint max(ref uint a, uint b)
        {
            a = a > b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref long max(ref long a, long b)
        {
            a = a > b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ulong max(ref ulong a, ulong b)
        {
            a = a > b ? a : b;
            return ref a;
        }

    }
}