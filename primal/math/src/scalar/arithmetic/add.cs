//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    using static zfunc;    

    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte add(sbyte a, sbyte b)
            => (sbyte)(a + b);

        [MethodImpl(Inline)]
        public static byte add(byte a, byte b)
            => (byte)(a + b);


        [MethodImpl(Inline)]
        public static short add(short a, short b)
            => (short)(a + b);

        [MethodImpl(Inline)]
        public static ushort add(ushort a, ushort b)
            => (ushort)(a + b);

        [MethodImpl(Inline)]
        public static int add(int a, int b)
            => a + b;

        [MethodImpl(Inline)]
        public static uint add(uint a, uint b)
            => a + b;

        [MethodImpl(Inline)]
        public static long add(long a, long b)
            => a + b;

        [MethodImpl(Inline)]
        public static ulong add(ulong a, ulong b)
            => a + b;

        [MethodImpl(Inline)]
        public static ref sbyte add(ref sbyte a, sbyte b)
        {
            a = (sbyte)(a + b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref byte add(ref byte a, byte b)
        {
            a = (byte)(a + b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref short add(ref short a, short b)
        {
            a = (short)(a + b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ushort add(ref ushort a, ushort b)
        {
            a = (ushort)(a + b);
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref int add(ref int a, int b)
        {
            a = a + b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref uint add(ref uint a, uint b)
        {
            a = a + b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref long add(ref long a, long b)
        {
            a = a + b;
            return ref a;
        }

        [MethodImpl(Inline)]
        public static ref ulong add(ref ulong a, ulong b)
        {
            a = a + b;
            return ref a;
        }
    }
}