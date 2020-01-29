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
    
    /// <summary>
    /// Generic intrinsics over floating-point domains
    /// </summary>
    public static class ginxfp
    {
       [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
       public static Vector128<T> vadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vadd(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vadd(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
       public static Vector256<T> vadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vadd(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vadd(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }     

       [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
       public static Vector128<T> vsub<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vsub(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vsub(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
       public static Vector256<T> vsub<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vsub(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vsub(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }        

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> vhadd<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vhadd(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vhadd(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector256<T> vhadd<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vhadd(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vhadd(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> vdiv<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vdiv(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vdiv(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector256<T> vdiv<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vdiv(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vdiv(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> vand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vand(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vand(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
                    
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector256<T> vand<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vand(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vand(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
                    
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> vor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vor(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vor(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector256<T> vor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vor(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vor(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> vxor<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vxor(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vxor(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector256<T> vxor<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vxor(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vxor(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> vxornot<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vxornot(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vxornot(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector256<T> vxornot<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vxornot(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vxornot(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> vmin<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vmin(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vmin(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }
         
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector256<T> vmin<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vmin(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vmin(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> vmax<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vmax(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vmax(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }        

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector256<T> vmax<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vmax(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vmax(v64f(x), v64f(y)));
            else 
                throw unsupported<T>();
        }        

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> vnegate<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vnegate(v32f(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vnegate(v64f(src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector256<T> vnegate<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxfp.vnegate(v32f(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxfp.vnegate(v64f(src)));
            else 
                throw unsupported<T>();
        }
    }
}