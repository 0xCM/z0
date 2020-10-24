//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;

    partial struct AsDeprecated
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(char src)
            => As<char,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(bool src)
            => As<bool,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(sbyte src)
            => As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(byte src)
            => As<byte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(short src)
            => As<short,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(ushort src)
            => As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(int src)
            => As<int,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(uint src)
            => As<uint,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(long src)
            => As<long,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(ulong src)
            => As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(float src)
            => As<float,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(double src)
            => As<double,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T generic<T>(decimal src)
            => As<decimal,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref sbyte src)
            => ref As<sbyte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref byte src)
            => ref As<byte,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref short src)
            => ref As<short,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref ushort src)
            => ref As<ushort,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref int src)
            => ref As<int,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref uint src)
            => ref As<uint,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref ulong src)
            => ref As<ulong,T>(ref src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T generic<T>(ref decimal src)
            => ref As<decimal,T>(ref src);
    }
}