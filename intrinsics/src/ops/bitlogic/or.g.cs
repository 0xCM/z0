//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        [MethodImpl(Inline)]
        public static Vector128<T> vor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vor_128u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vor_128i(x,y);
            else 
                return vor_128f(x,y);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vor_256u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vor_256i(x,y);
            else 
                return vor_256f(x,y);
        }

        /// <summary>
        /// Computes the bitwise or
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Vector512<T> vor<T>(in Vector512<T> x, in Vector512<T> y)
            where T : unmanaged
                => (vor(x.Lo,y.Lo), (vor(x.Hi, y.Hi)));

        [MethodImpl(Inline)]
        static Vector128<T> vor_128u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vor(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vor(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vor(vcast32u(x), vcast32u(y)));
            else
                return vgeneric<T>(dinx.vor(vcast64u(x), vcast64u(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vor_128i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(dinx.vor(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(dinx.vor(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vor(vcast32i(x), vcast32i(y)));
            else
                return vgeneric<T>(dinx.vor(vcast64i(x), vcast64i(y)));
        }
 
 
        [MethodImpl(Inline)]
        static Vector128<T> vor_128f<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vor(vcast64f(x), vcast64f(y)));
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static Vector256<T> vor_256u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vor(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vor(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vor(vcast32u(x), vcast32u(y)));
            else
                return vgeneric<T>(dinx.vor(vcast64u(x), vcast64u(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vor_256i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vor(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vor(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vor(vcast32i(x), vcast32i(y)));
            else
                return vgeneric<T>(dinx.vor(vcast64i(x), vcast64i(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vor_256f<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vor(vcast64f(x), vcast64f(y)));
            else
                throw unsupported<T>();
        }
    }
}