//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial struct gcpu
    {
        /// <summary>
        /// src[0..n-1] -> rm[n]:[0..n-1] where m = bitsize[T]
        /// Extracts/moves the first vector cell to a non-vector register of commensurate size
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T vmovelo<T>(Vector128<T> src)
            where T : unmanaged
                => vmovelo_u(src);

        [MethodImpl(Inline)]
        static T vmovelo_u<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return generic<T>(cpu.vmovelo(v8u(x), w8));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(cpu.vmovelo(v16u(x), w16));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(cpu.vmovelo(v32u(x), w32));
            else if(typeof(T) == typeof(ulong))
                 return generic<T>(cpu.vmovelo(v64u(x), w64));
            else
                return vmovelo_i(x);
        }

        [MethodImpl(Inline)]
        static T vmovelo_i<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(cpu.vmovelo(v8i(x), w8));
            else if(typeof(T) == typeof(short))
                 return generic<T>(cpu.vmovelo(v16i(x), w16));
            else if(typeof(T) == typeof(int))
                 return generic<T>(cpu.vmovelo(v32i(x), w32));
            else if(typeof(T) == typeof(long))
                 return generic<T>(cpu.vmovelo(v64i(x), w64));
            else
                throw no<T>();
        }
    }
}