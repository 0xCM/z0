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
    
    public static class gfpv
    {

        [MethodImpl(Inline)]
        public static Vector128<T> vhadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vhadd(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vhadd(float64(x), float64(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vhadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vhadd(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vhadd(float64(x), float64(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vdiv<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vdiv(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vdiv(float64(x), float64(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vdiv<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vdiv(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vdiv(float64(x), float64(y)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vector128<T> vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vand(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vand(float64(x), float64(y)));
            else 
                throw unsupported<T>();
                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vand<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vand(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vand(float64(x), float64(y)));
            else 
                throw unsupported<T>();
                    
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vor(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vor(float64(x), float64(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vor(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vor(float64(x), float64(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vxor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxor(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxor(float64(x), float64(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxor(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxor(float64(x), float64(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vxornot<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxornot(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxornot(float64(x), float64(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxornot<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxornot(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxornot(float64(x), float64(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vmin<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vmin(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vmin(float64(x), float64(y)));
            else 
                throw unsupported<T>();

        }
         
        [MethodImpl(Inline)]
        public static Vector256<T> vmin<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vmin(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vmin(float64(x), float64(y)));
            else 
                throw unsupported<T>();

        }

       [MethodImpl(Inline)]
       public static Vector128<T> vmax<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vmax(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vmax(float64(x), float64(y)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline)]
       public static Vector256<T> vmax<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vmax(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vmax(float64(x), float64(y)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline)]
       public static Vector128<T> vadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vadd(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vadd(float64(x), float64(y)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline)]
       public static Vector256<T> vadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vadd(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vadd(float64(x), float64(y)));
            else 
                throw unsupported<T>();
        }        


        [MethodImpl(Inline)]
        public static Vector128<T> vnegate<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vnegate(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vnegate(float64(src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnegate<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vnegate(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vnegate(float64(src)));
            else 
                throw unsupported<T>();
        }
    }
}