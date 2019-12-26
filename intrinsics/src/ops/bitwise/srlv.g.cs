//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;
    
    partial class ginx
    {        
        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..n-1 for vectors of length n
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vsrlv<T>(Vector128<T> x, Vector128<T> offsets)
            where T : unmanaged
                => vsrlv_u(x,offsets);

        /// <summary>
        /// Computes z[i] := x[i] >> s[i] for i = 0..n-1 vectors of length n
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vsrlv<T>(Vector256<T> x, Vector256<T> offsets)
            where T : unmanaged
                => vsrlv_u(x,offsets);

        [MethodImpl(Inline)]
        static Vector128<T> vsrlv_u<T>(Vector128<T> x, Vector128<T> offsets)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrlv(v8u(x), v8u(offsets)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrlv(v16u(x), v16u(offsets)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vsrlv(v32u(x), v32u(offsets)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vsrlv(v64u(x), v64u(offsets)));            
            else
                return vsrlv_i(x,offsets);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrlv_i<T>(Vector128<T> x, Vector128<T> offsets)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsrlv(v8i(x), v8i(offsets)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrlv(v16i(x), v16i(offsets)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsrlv(v32i(x), v32i(offsets)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vsrlv(v64i(x), v64i(offsets)));            
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static Vector256<T> vsrlv_u<T>(Vector256<T> x, Vector256<T> offsets)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrlv(v8u(x), v8u(offsets)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrlv(v16u(x), v16u(offsets)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vsrlv(v32u(x), v32u(offsets)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vsrlv(v64u(x), v64u(offsets)));            
            else
                return vsrlv_i(x,offsets);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlv_i<T>(Vector256<T> x, Vector256<T> offsets)
            where T : unmanaged
        {
             if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsrlv(v8i(x), v8i(offsets)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrlv(v16i(x), v16i(offsets)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsrlv(v32i(x), v32i(offsets)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vsrlv(v64i(x), v64i(offsets)));            
            else
                throw unsupported<T>();
       }
    }
}