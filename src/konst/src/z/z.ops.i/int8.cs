//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static sbyte int8<T>(T src)
            => As<T,sbyte>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static sbyte? int8<T>(T? src)
            where T : unmanaged
                => As<T?, sbyte?>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref sbyte int8<T>(ref T src)
            => ref As<T,sbyte>(ref src);


        [MethodImpl(Inline), Op]
        public static sbyte int8(sbyte src)
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte int8(byte src)
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte int8(short src)
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte int8(ushort src)
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte int8(int src)
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte int8(uint src)
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte int8(long src)
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte int8(ulong src)
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte int8(float src)
            => (sbyte)((int)src);

        [MethodImpl(Inline), Op]
        public static sbyte int8(double src)
            => (sbyte)((long)src);
    }
}