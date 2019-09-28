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
    using static AsIn;
    using static zfunc;    
    
    /// <summary>
    /// Generic scalar intrinsics
    /// </summary>
    public static class ginxs
    {
        [MethodImpl(Inline)]
        public static Vector128<T> add<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.add(in float32(in lhs), in float32(in rhs)).As<float,T>();
            else if(typeof(T) == typeof(double))
                return inxs.add(in float64(in lhs), in float64(in rhs)).As<double,T>();
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Scalar128<T> sub<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.sub(in float32(in lhs), in float32(in rhs)).As<T>();
            else if(typeof(T) == typeof(double))
                return inxs.sub(in float64(in lhs), in float64(in rhs)).As<T>();
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Scalar128<T> mul<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.mul(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return inxs.mul(in float64(in lhs), in float64(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Scalar128<T> div<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.div(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return inxs.div(in float64(in lhs), in float64(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Scalar128<T> min<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.min(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return inxs.min(in float64(in lhs), in float64(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Scalar128<T> max<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.max(in float32(in lhs), in float32(in rhs)).As<T>();            
            else if(typeof(T) == typeof(double))
                return inxs.max(in float64(in lhs), in float64(in rhs)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Scalar128<T> fmadd<T>(ref Scalar128<T> x, in Scalar128<T> y, in Scalar128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dfp.fmadd(in float32(in x), float32(in y), in float32(in z)).As<T>();                
            else if(typeof(T) == typeof(double))
                return dfp.fmadd(in float64(in x), float64(in y), in float64(in z)).As<T>();
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool eq<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.eq(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return inxs.eq(in float64(in lhs), in float64(in rhs));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool neq<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.cmpneq(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return inxs.cmpneq(in float64(in lhs), in float64(in rhs));
            else 
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static bool lteq<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.lteq(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return inxs.lteq(in float32(in lhs), in float32(in rhs));
            else                
                throw unsupported<T>();
        }
 

        [MethodImpl(Inline)]
        public static bool ngt<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.ngt(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return inxs.ngt(in float32(in lhs), in float32(in rhs));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool nlt<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.nlt(in float32(in lhs), in float32(in rhs));            
            else if(typeof(T) == typeof(double))
                return inxs.nlt(in float32(in lhs), in float32(in rhs));
            else                
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        public static bool gt<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.gt(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return inxs.gt(in float64(in lhs), in float64(in rhs));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dfp.gteq(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return dfp.gteq(in float64(in lhs), in float64(in rhs));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lt<T>(in Scalar128<T> lhs, in Scalar128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxs.lt(in float32(in lhs), in float32(in rhs));
            else if(typeof(T) == typeof(double))
                return inxs.lt(in float64(in lhs), in float64(in rhs));
            throw unsupported<T>();
        }   
    }

}