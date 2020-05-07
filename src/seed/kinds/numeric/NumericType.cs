//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class NumericType
    {
        [MethodImpl(Inline), Op]
        public static Type int8i() => typeof(sbyte);

        [MethodImpl(Inline), Op]
        public static Type int8u() => typeof(byte);

        [MethodImpl(Inline), Op]
        public static Type int16i() => typeof(short);

        [MethodImpl(Inline), Op]
        public static Type int16u() => typeof(ushort);

        [MethodImpl(Inline), Op]
        public static Type int32i() => typeof(int);

        [MethodImpl(Inline), Op]
        public static Type int32u() => typeof(uint);

        [MethodImpl(Inline), Op]
        public static Type int64i() => typeof(long);

        [MethodImpl(Inline), Op]
        public static Type int64u() => typeof(ulong);

        [MethodImpl(Inline), Op]
        public static Type float32() => typeof(float);

        [MethodImpl(Inline), Op]
        public static Type float64() => typeof(double);

    }
}