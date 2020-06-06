//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;
    
    partial class Vectors
    {
        /// <summary>
        /// Extracts the lo 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Vector128<T> vlo<T>(Vector256<T> src)
            where T : unmanaged
                => vlo_u(src);

        [MethodImpl(Inline)]
        static Vector128<T> vlo_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(vlo(v8u(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(vlo(v16u(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(vlo(v32u(src)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(vlo(v64u(src)));
            else
                return vlo_i(src);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vlo_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(vlo(v8i(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(vlo(v16i(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(vlo(v32i(src)));
            else if(typeof(T) == typeof(long))
                return generic<T>(vlo(v64i(src)));
            else
                return vlo_f(src);            
        }

        [MethodImpl(Inline)]
        static Vector128<T> vlo_f<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(vlo(v32f(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(vlo(v64f(src)));
            else 
                throw Unsupported.define<T>();
        }
    }
}