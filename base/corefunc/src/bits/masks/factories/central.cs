//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi1;
    using static System.Runtime.Intrinsics.X86.Bmi1.X64;

    using static zfunc;
    using static BitMasks;

    partial class BitMask
    {                
        [MethodImpl(Inline)]
        public static CentralMask<F,D,T> centralspec<F,D,T>(F f = default, D d = default, T t = default) 
            where F : unmanaged, ITypeNat
            where D : unmanaged, ITypeNat
            where T : unmanaged
                => default;

        /// <summary>
        /// [00011000]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(N8 f, N2 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Central8x8x2);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Central16x8x2);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Central32x8x2);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Central64x8x2);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [00011000]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(CentralMask<N8,N2,T> spec)
            where T : unmanaged
                => central(spec.f,spec.d, spec.t);

        /// <summary>
        /// [00111100]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(N8 f, N4 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Central8x8x4);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Central16x8x4);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Central32x8x4);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Central64x8x4);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [00111100]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(CentralMask<N8,N4,T> spec)
            where T : unmanaged
                => central(spec.f,spec.d, spec.t);

        /// <summary>
        /// [01111110]
        /// </summary>
        /// <param name="f">The repetition frequency</param>
        /// <param name="d">The bit density</param>
        /// <param name="t">A mask type representative</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(N8 f, N6 d, T t = default)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<byte,T>(Central8x8x6);
            else if(typeof(T) == typeof(ushort))
                return convert<ushort,T>(Central16x8x6);
            else if(typeof(T) == typeof(uint))
                return convert<uint,T>(Central32x8x6);
            else if(typeof(T) == typeof(ulong))
                return convert<ulong,T>(Central64x8x6);
            else 
                throw unsupported<T>();
        }

        /// <summary>
        /// [01111110]
        /// </summary>
        /// <param name="spec">The mask spec</param>
        /// <typeparam name="T">The mask data type</typeparam>
        [MethodImpl(Inline)]
        public static T central<T>(CentralMask<N8,N6,T> spec)
            where T : unmanaged
                => central(spec.f,spec.d, spec.t);


    }
}