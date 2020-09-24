//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost("numeric.array")]
    public readonly struct NumericArray
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] to<T>(byte[] src, T[] dst)
            where T : unmanaged
                => to<byte,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] to<T>(sbyte[] src, T[] dst)
            where T : unmanaged
                => to<sbyte,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] to<T>(short[] src, T[] dst)
            where T : unmanaged
                => to<short,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] to<T>(ushort[] src, T[] dst)
            where T : unmanaged
                => to<ushort,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] to<T>(int[] src, T[] dst)
            where T : unmanaged
                => to<int,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] to<T>(uint[] src, T[] dst)
            where T : unmanaged
                => to<uint,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] to<T>(long[] src, T[] dst)
            where T : unmanaged
                => to<long,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] to<T>(ulong[] src, T[] dst)
            where T : unmanaged
                => to<ulong,T>(src, dst);


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] to<T>(float[] src, T[] dst)
            where T : unmanaged
                => to<float,T>(src, dst);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static T[] to<T>(double[] src, T[] dst)
            where T : unmanaged
                => to<double,T>(src, dst);

        [MethodImpl(Inline)]
        public static T[] to<T>(byte[] src)
            where T : unmanaged
                => to<byte,T>(src);

        [MethodImpl(Inline)]
        public static T[] to<T>(sbyte[] src)
            where T : unmanaged
                => to<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static T[] to<T>(short[] src)
            where T : unmanaged
                => to<short,T>(src);

        [MethodImpl(Inline)]
        public static T[] to<T>(ushort[] src)
            where T : unmanaged
                => to<ushort,T>(src);

        [MethodImpl(Inline)]
        public static T[] to<T>(int[] src)
            where T : unmanaged
                => to<int,T>(src);

        [MethodImpl(Inline)]
        public static T[] to<T>(uint[] src)
            where T : unmanaged
                => to<uint,T>(src);

        [MethodImpl(Inline)]
        public static T[] to<T>(long[] src)
            where T : unmanaged
                => to<long,T>(src);

        [MethodImpl(Inline)]
        public static T[] to<T>(ulong[] src)
            where T : unmanaged
                => to<ulong,T>(src);

        [MethodImpl(Inline)]
        public static T[] to<T>(float[] src)
            where T : unmanaged
                => to<float,T>(src);

        [MethodImpl(Inline)]
        public static T[] to<T>(double[] src)
            where T : unmanaged
                => to<double,T>(src);

        /// <summary>
        /// Unconditionally converts the source values to values of parametric numeric type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static T[] to<S,T>(S[] src, T[] dst)
            where T : unmanaged
            where S : unmanaged
        {
            var input = src.ToSpan();
            var count = input.Length;
            var target = dst.ToSpan();
            for(var i=0; i<count; i++)
                z.seek(target,(uint)i) = z.force<S,T>(z.skip(input,(uint)i));
            return dst;
        }

        /// <summary>
        /// Unconditionally converts the source values to values of parametric numeric type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline)]
        public static T[] to<S,T>(S[] src)
            where T : unmanaged
            where S : unmanaged
        {
            var input = src.ToSpan();
            var count = input.Length;
            var buffer = sys.alloc<T>(count);
            var dst = buffer.ToSpan();
            for(var i=0; i<count; i++)
                z.seek(dst,(uint)i) = z.force<S,T>(z.skip(input,(uint)i));
            return buffer;
        }
    }
}