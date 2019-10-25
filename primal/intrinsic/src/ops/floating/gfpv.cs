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
        public static Vector128<T> vhadd<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vhadd(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vhadd(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vhadd<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vhadd(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vhadd(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vdiv<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vdiv(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vdiv(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vdiv<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vdiv(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vdiv(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }

       [MethodImpl(Inline)]
       public static Vec128<T> vmax<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vmax(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vmax(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }        

        [MethodImpl(Inline)]
        public static Vector128<T> vand<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vand(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vand(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vand<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vand(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vand(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
                    
        }

        [MethodImpl(Inline)]
        public static Vec128<T> vor<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vor(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vor(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vor<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vor(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vor(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();                    
        }

        [MethodImpl(Inline)]
        public static Vec128<T> vxor<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxor(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxor(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
                    
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxor<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxor(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxor(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
                    
        }

       [MethodImpl(Inline)]
       public static Vector256<T> vmax<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vmax(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vmax(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }        

        [MethodImpl(Inline)]
        public static Vec128<T> vmin<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vmin(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vmin(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();

        }
         
       [MethodImpl(Inline)]
       public static Vec256<T> vmin<T>(in Vec256<T> lhs, in Vec256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vmin(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vmin(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline)]
       public static Vec128<T> vadd<T>(in Vec128<T> lhs, in Vec128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vadd(in float32(in lhs), in float32(in rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vadd(in float64(in lhs), in float64(in rhs)));
            else 
                throw unsupported<T>();
        }        

       [MethodImpl(Inline)]
       public static Vector128<T> vadd<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vadd(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vadd(float64(lhs), float64(rhs)));
            else 
                throw unsupported<T>();
        }        


       [MethodImpl(Inline)]
       public static Vector256<T> vadd<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vadd(float32(lhs), float32(rhs)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vadd(float64(lhs), float64(rhs)));
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