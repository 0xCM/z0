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
    
    using static zfunc;

    using static As;

    partial class ginx
    {
        /// <summary>
        /// Computes the component-wise sum of two vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vadd_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vadd_i(x,y);
            else 
                return gfpv.vadd(x,y);
        }
        
        /// <summary>
        /// Computes the component-wise sum of two vectors
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vadd_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vadd_i(x,y);
            else 
                return gfpv.vadd(x,y);
        }

        /// <summary>
        /// Adds a constant value to each vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="a">The value to add to each component</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector128<T> vadd<T>(Vector128<T> x, T a)
            where T : unmanaged
                => vadd(x, vbuild.vbroadcast(n128,a));

        /// <summary>
        /// Adds a constant value to each vector component
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="a">The value to add to each component</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Vector256<T> vadd<T>(Vector256<T> x, T a)
            where T : unmanaged
                => vadd(x, vbuild.vbroadcast(n256,a));
    
        [MethodImpl(Inline)]
        static Vector128<T> vadd_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return As.vgeneric<T>(dinx.vadd(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                 return As.vgeneric<T>(dinx.vadd(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                 return vgeneric<T>(dinx.vadd(vcast32i(x), vcast32i(y)));
            else
                 return vgeneric<T>(dinx.vadd(vcast64i(x), vcast64i(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vadd_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vadd(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vadd(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vadd(vcast32u(x), vcast32u(y)));
            else 
                return vgeneric<T>(dinx.vadd(vcast64u(x), vcast64u(y)));
        }


        [MethodImpl(Inline)]
        static Vector256<T> vadd_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return vgeneric<T>(dinx.vadd(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                 return vgeneric<T>(dinx.vadd(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                 return vgeneric<T>(dinx.vadd(vcast32i(x), vcast32i(y)));
            else
                 return vgeneric<T>(dinx.vadd(vcast64i(x), vcast64i(y)));
        }    


        [MethodImpl(Inline)]
        static Vector256<T> vadd_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vadd(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vadd(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vadd(vcast32u(x), vcast32u(y)));
            else 
                return vgeneric<T>(dinx.vadd(vcast64u(x), vcast64u(y)));
        }    

    }
}
