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
                return vgeneric<T>(fpinx.vhadd(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vhadd(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vhadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vhadd(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vhadd(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vdiv<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vdiv(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vdiv(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vdiv<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vdiv(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vdiv(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vector128<T> vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vand(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vand(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vand<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vand(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vand(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
                    
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vor(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vor(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vxor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vxor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vxor(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vxor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vxor(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vxornot<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vxornot(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vxornot(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxornot<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vxornot(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vxornot(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vmin<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vmin(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vmin(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();

        }
         
        [MethodImpl(Inline)]
        public static Vector256<T> vmin<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vmin(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vmin(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();

        }

       [MethodImpl(Inline)]
       public static Vector128<T> vmax<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vmax(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vmax(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline)]
       public static Vector256<T> vmax<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vmax(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vmax(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline)]
       public static Vector128<T> vadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vadd(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vadd(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline)]
       public static Vector256<T> vadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vadd(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vadd(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }        


        [MethodImpl(Inline)]
        public static Vector128<T> vnegate<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vnegate(vcast32f(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vnegate(vcast64f(src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnegate<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vnegate(vcast32f(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vnegate(vcast64f(src)));
            else 
                throw unsupported<T>();
        }
    }
}