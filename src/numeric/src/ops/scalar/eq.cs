//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;    

    partial class Scalar
    {
        [MethodImpl(Inline), Op]
        public static bit eq(sbyte a, sbyte b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static bit eq(byte a, byte b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static bit eq(short a, short b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static bit eq(ushort a, ushort b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static bit eq(int a, int b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static bit eq(uint a, uint b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static bit eq(long a, long b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static bit eq(ulong a, ulong b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static bit eq(float a, float b)
            => a == b;

        [MethodImpl(Inline), Op]
        public static bit eq(double a, double b)
            => a == b;
    }
}