//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        /// <summary>
        /// Efects a "paired" or "permutation" blend that computes the vectors
        /// lo := vblendv(x,y,spec)
        /// hi := vblendv(x,y,vnot(spec))
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <param name="spec">The blend spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> vblendp<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)        
            where T : unmanaged
                => (vblendv(x,y,spec),vblendv(x,y,vnot(spec)));

        /// <summary>
        /// Efects a "paired" or "permutation" blend that computes the vectors
        /// lo := vblendv(x,y,spec)
        /// hi := vblendv(x,y,vnot(spec))
        /// </summary>
        /// <param name="x">The first vector</param>
        /// <param name="y">The second vector</param>
        /// <param name="spec">The blend spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vblendp<T>(Vector128<T> x, Vector128<T> y, Vector128<T> spec)        
            where T : unmanaged
                => vconcat(vblendv(x,y,spec),vblendv(x,y,vnot(spec)));

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vblendv<T>(Vector128<T> x, Vector128<T> y, Vector128<T> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vblendv(vcast8u(x), vcast8u(y), vcast8u(spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblendv(vcast16u(x), vcast16u(y), vcast16u(spec)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblendv(vcast32u(x), vcast32u(y), vcast32u(spec)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vblendv(vcast64u(x), vcast64u(y), vcast64u(spec)));
            else
                return vblendv_i(x,y,spec);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblendv_i<T>(Vector128<T> x, Vector128<T> y, Vector128<T> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vblendv(vcast8i(x), vcast8i(y), vcast8i(spec)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblendv(vcast16i(x), vcast16i(y), vcast16i(spec)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblendv(vcast32i(x), vcast32i(y), vcast32i(spec)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vblendv(vcast64i(x), vcast64i(y), vcast64i(spec)));
            else
                return vblendv_f(x,y,spec);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vblendv_f<T>(Vector128<T> x, Vector128<T> y, Vector128<T> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinx.vblendv(vcast32f(x), vcast32f(y), vcast32f(spec)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinx.vblendv(vcast64f(x), vcast64f(y), vcast64f(spec)));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="spec">The blend specification</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vblendv<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vblendv(vcast8u(x), vcast8u(y), vcast8u(spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vblendv(vcast16u(x), vcast16u(y), vcast16u(spec)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vblendv(vcast32u(x), vcast32u(y), vcast32u(spec)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vblendv(vcast64u(x), vcast64u(y), vcast64u(spec)));
            else
                return vblendv_i(x,y,spec);

        }

        [MethodImpl(Inline)]
        static Vector256<T> vblendv_i<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)        
            where T : unmanaged
        {
             if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vblendv(vcast8i(x), vcast8i(y), vcast8i(spec)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vblendv(vcast16i(x), vcast16i(y), vcast16i(spec)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vblendv(vcast32i(x), vcast32i(y), vcast32i(spec)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vblendv(vcast64i(x), vcast64i(y), vcast64i(spec)));
            else
                return vblendv_f(x,y,spec);

        }

        [MethodImpl(Inline)]
        static Vector256<T> vblendv_f<T>(Vector256<T> x, Vector256<T> y, Vector256<T> spec)        
            where T : unmanaged
        {
             if(typeof(T) == typeof(float))
                return vgeneric<T>(dinx.vblendv(vcast32f(x), vcast32f(y), vcast32f(spec)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinx.vblendv(vcast64f(x), vcast64f(y), vcast64f(spec)));
            else
                throw unsupported<T>();

        }


    }

}