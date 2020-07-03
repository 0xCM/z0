//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Konst; 
    using static As;
    using static V0d;
    using static Typed;
    
    partial class gvec
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
                 return generic<T>(vmove(v8u(x), n8));
            else if(typeof(T) == typeof(ushort))
                 return generic<T>(vmove(v16u(x), n16));
            else if(typeof(T) == typeof(uint))
                 return generic<T>(vmove(v32u(x), n32));
            else if(typeof(T) == typeof(ulong))
                 return generic<T>(vmove(v64u(x), n64));
            else
                return vmovelo_i(x);
        }

        [MethodImpl(Inline)]
        static T vmovelo_i<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(vmove(v8i(x), n8));
            else if(typeof(T) == typeof(short))
                 return generic<T>(vmove(v16i(x), n16));
            else if(typeof(T) == typeof(int))
                 return generic<T>(vmove(v32i(x), n32));
            else if(typeof(T) == typeof(long))
                 return generic<T>(vmove(v64i(x), n64));
            else
                throw Unsupported.define<T>();
        }
    }
}