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
                 return generic<T>(cpu.vint8u(v8u(x)));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(cpu.vint16u(v16u(x)));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(cpu.vint32u(v32u(x)));
            else if(typeof(T) == typeof(ulong))
                 return generic<T>(cpu.vint64u(v64u(x)));
            else
                return vmovelo_i(x);
        }

        [MethodImpl(Inline)]
        static T vmovelo_i<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(cpu.vint8i(v8i(x)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(cpu.vint16i(v16i(x)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(cpu.vint32i(v32i(x)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(cpu.vint64i(v64i(x)));
            else
                throw no<T>();
        }
    }
}