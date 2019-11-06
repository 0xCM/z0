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
        public static sbyte min(sbyte a, sbyte b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static byte min(byte a, byte b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static short min(short a, short b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static ushort min(ushort a, ushort b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static int min(int a, int b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static uint min(uint a, uint b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static long min(long a, long b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static ulong min(ulong a, ulong b)
            => a < b ? a : b;

        [MethodImpl(Inline)]
        public static ref sbyte min(ref sbyte a, sbyte b)
        {
            a = a < b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref byte min(ref byte a, byte b)
        {
            a = a < b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref short min(ref short a, short b)
        {
            a = a < b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ushort min(ref ushort a, ushort b)
        {
            a = a < b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref int min(ref int a, int b)
        {
            a = a < b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref uint min(ref uint a, uint b)
        {
            a = a < b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref long min(ref long a, long b)
        {
            a = a < b ? a : b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ulong min(ref ulong a, ulong b)
        {
            a = a < b ? a : b;
            return ref a;
        }
    }
}