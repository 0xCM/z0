//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class math
    {
        [MethodImpl(Inline)]
        public static sbyte cimpl(sbyte a, sbyte b)
            => or(not(a),b);

        [MethodImpl(Inline)]
        public static byte cimpl(byte a, byte b)
            => (byte)(~a | b);

        [MethodImpl(Inline)]
        public static short cimpl(short a, short b)
            => or(not(a),b);

        [MethodImpl(Inline)]
        public static ushort cimpl(ushort a, ushort b)
            => (ushort)(~a | b);

        [MethodImpl(Inline)]
        public static int cimpl(int a, int b)
            => ~a | b;

        [MethodImpl(Inline)]
        public static uint cimpl(uint a, uint b)
            => ~a | b;

        [MethodImpl(Inline)]
        public static long cimpl(long a, long b)
            => ~a | b;

        [MethodImpl(Inline)]
        public static ulong cimpl(ulong a, ulong b)
            => ~a | b;
    }
}