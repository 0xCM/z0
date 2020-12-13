//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public readonly struct Ranges
    {
       [MethodImpl(Inline), Op, Closures(Integers)]
       public static void range8i<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,sbyte>(ref x0);
            var max = Unsafe.As<T,sbyte>(ref x1);
            var _step = Unsafe.As<T?, sbyte?>(ref step) ??(sbyte)1;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<sbyte,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range8u<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,byte>(ref x0);
            var max = Unsafe.As<T,byte>(ref x1);
            var _step = Unsafe.As<T?, byte?>(ref step) ??(byte)1;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<byte,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range16i<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,short>(ref x0);
            var max = Unsafe.As<T,short>(ref x1);
            var _step = Unsafe.As<T?, short?>(ref step) ?? (short)1;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<short,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range16u<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,ushort>(ref x0);
            var max = Unsafe.As<T,ushort>(ref x1);
            var _step = Unsafe.As<T?, ushort?>(ref step) ?? (ushort)1;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<ushort,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range32i<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,int>(ref x0);
            var max = Unsafe.As<T,int>(ref x1);
            var _step = Unsafe.As<T?, int?>(ref step) ?? 1;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<int,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range32u<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,uint>(ref x0);
            var max = Unsafe.As<T,uint>(ref x1);
            var _step = Unsafe.As<T?, uint?>(ref step) ?? 1u;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<uint,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range64i<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,long>(ref x0);
            var max = Unsafe.As<T,long>(ref x1);
            var _step = Unsafe.As<T?, long?>(ref step) ?? 1L;
            for(var i = min; i <= max; i += _step)
                seek(dst,i) = Unsafe.As<long,T>(ref i);
        }

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static void range64u<T>(T x0, T x1, T? step, Span<T> dst)
            where T : unmanaged
        {
            var min = Unsafe.As<T,ulong>(ref x0);
            var max = Unsafe.As<T,ulong>(ref x1);
            var _step = Unsafe.As<T?, ulong?>(ref step) ?? 1ul;
            for(var i = min; i <= max; i += _step)
                seek(dst, i) = Unsafe.As<ulong,T>(ref i);
        }
    }
}