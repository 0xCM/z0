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
    using static BitMasks.Literals;

    partial class BitMasks
    {
        /// <summary>
        /// [01010101]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T even<T>(N2 f, N1 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Even8);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Even16);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Even32);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Even64);
            else
                throw no<T>();
        }

        /// <summary>
        /// [00110011]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T even<T>(N2 f, N2 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Even8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Even16x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Even32x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Even64x2);
            else
                throw no<T>();
        }

        /// <summary>
        /// [10101010]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T odd<T>(N2 f, N1 d)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Odd8);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Odd16);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Odd32);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Odd64);
            else
                throw no<T>();
        }


        /// <summary>
        /// [11001100]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T odd<T>(N2 f, N2 d)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Odd8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Odd16x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Odd32x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Odd64x2);
            else
                throw no<T>();
        }

        /// <summary>
        /// [01010101]
        /// </summary>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(in ParityMask<N2,N1,T> spec, N0 e)
            where T : unmanaged
                => even(spec.f, spec.d, spec.t);

        /// <summary>
        /// [10101010]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(in ParityMask<N2,N1,T> spec, N1 o)
            where T : unmanaged
                => odd<T>(spec. f,spec.d);

        /// <summary>
        /// [00110011]
        /// </summary>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(in ParityMask<N2,N2,T> spec, N0 e)
            where T : unmanaged
                => even(spec.f, spec.d, spec.t);

        /// <summary>
        /// [11001100]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T mask<T>(in ParityMask<N2,N2,T> spec, N1 o)
            where T : unmanaged
                => odd<T>(spec.f, spec.d);
    }
}