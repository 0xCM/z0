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
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in char src)
            => ref As<char,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in bool src)
            => ref As<bool,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in sbyte src)
            => ref As<sbyte,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in byte src)
            => ref As<byte,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in short src)
            => ref As<short,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in ushort src)
            => ref As<ushort,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in int src)
            => ref As<int,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in uint src)
            => ref As<uint,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in long src)
            => ref As<long,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in ulong src)
            => ref As<ulong,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in float src)
            => ref As<float,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in double src)
            => ref As<double,T>(ref AsRef(src));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ref T gref<T>(in decimal src)
            => ref As<decimal,T>(ref AsRef(src));
    }
}