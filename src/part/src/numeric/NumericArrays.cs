//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct NumericArrays
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] force<T>(byte[] src, T[] dst)
            where T : unmanaged
                => force<byte,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] force<T>(sbyte[] src, T[] dst)
            where T : unmanaged
                => force<sbyte,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] force<T>(short[] src, T[] dst)
            where T : unmanaged
                => force<short,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] force<T>(ushort[] src, T[] dst)
            where T : unmanaged
                => force<ushort,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] force<T>(int[] src, T[] dst)
            where T : unmanaged
                => force<int,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] force<T>(uint[] src, T[] dst)
            where T : unmanaged
                => force<uint,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] force<T>(long[] src, T[] dst)
            where T : unmanaged
                => force<long,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] force<T>(ulong[] src, T[] dst)
            where T : unmanaged
                => force<ulong,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] force<T>(float[] src, T[] dst)
            where T : unmanaged
                => force<float,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] force<T>(double[] src, T[] dst)
            where T : unmanaged
                => force<double,T>(src, dst);

        /// <summary>
        /// Unconditionally converts the source values to values of parametric numeric type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static T[] force<S,T>(S[] src, T[] dst)
            where T : unmanaged
            where S : unmanaged
        {
            var input = memory.span(src);
            var count = input.Length;
            var target = memory.span(dst);
            for(var i=0; i<count; i++)
                memory.seek(target,(uint)i) = NumericCast.force<S,T>(memory.skip(input,(uint)i));
            return dst;
        }

        /// <summary>
        /// Unconditionally converts the source values to values of parametric numeric type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static T[] force<S,T>(S[] src)
            where T : unmanaged
            where S : unmanaged
        {
            var input = memory.span(src);
            var count = input.Length;
            var buffer = memory.alloc<T>(count);
            var dst = buffer.ToSpan();
            for(var i=0; i<count; i++)
                memory.seek(dst,(uint)i) = NumericCast.force<S,T>(memory.skip(input,(uint)i));
            return buffer;
        }
    }
}