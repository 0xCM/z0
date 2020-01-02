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
    
    public static partial class ginxfp
    {

        [MethodImpl(Inline)]
        public static Vector128<T> vhadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vhadd(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vhadd(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vhadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vhadd(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vhadd(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vdiv<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vdiv(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vdiv(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vdiv<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vdiv(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vdiv(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static Vector128<T> vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vand(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vand(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vand<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vand(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vand(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
                    
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vor<T>(Vector128<T> x, Vector128<T> y)
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
        public static Vector256<T> vor<T>(Vector256<T> x, Vector256<T> y)
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
        public static Vector128<T> vxor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vxor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vxor(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vxor(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vxor(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vxornot<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vxornot(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vxornot(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxornot<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vxornot(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vxornot(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vmin<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vmin(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vmin(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();

        }
         
        [MethodImpl(Inline)]
        public static Vector256<T> vmin<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vmin(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vmin(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();

        }

       [MethodImpl(Inline)]
       public static Vector128<T> vmax<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vmax(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vmax(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline)]
       public static Vector256<T> vmax<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vmax(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vmax(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline)]
       public static Vector128<T> vadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vadd(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vadd(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline)]
       public static Vector256<T> vadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vadd(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vadd(vcast64f(x), vcast64f(y)));
            else 
                throw unsupported<T>();
        }        


        [MethodImpl(Inline)]
        public static Vector128<T> vnegate<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vnegate(vcast32f(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vnegate(vcast64f(src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnegate<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vnegate(vcast32f(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vnegate(vcast64f(src)));
            else 
                throw unsupported<T>();
        }
    }
}