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
    public static class gfpsinx
    {

        [MethodImpl(Inline)]
        public static Vector128<T> load<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.load(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.load(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T store<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.store(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.store(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> add<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.add(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.add(float64(x), float64(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> sub<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.sub(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.sub(float64(x), float64(y)));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> mul<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.mul(float32(x), float32(y)));          
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.mul(float64(x), float64(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> div<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.div(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.div(float64(x), float64(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> min<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.min(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.min(float64(x), float64(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> max<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.max(float32(x), float32(y)));            
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.max(float64(x), float64(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> ceil<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.ceil(float32(x)));            
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.ceil(float64(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> floor<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.floor(float32(x)));            
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.floor(float64(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> sqrt<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.sqrt(float32(x)));            
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.sqrt(float64(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fmadd<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.fmadd(float32(x), float32(y), float32(z))); 
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.fmadd(float64(x), float64(y), float64(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fmsub<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.fmsub(float32(x), float32(y), float32(z))); 
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.fmsub(float64(x), float64(y), float64(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fnmadd<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.fnmadd(float32(x), float32(y), float32(z))); 
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.fnmadd(float64(x), float64(y), float64(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool eq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.eq(float32(x), float32(y));
            else if(typeof(T) == typeof(double))
                return fpsinx.eq(float64(x), float64(y));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool neq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.neq(float32(x), float32(y));
            else if(typeof(T) == typeof(double))
                return fpsinx.neq(float64(x), float64(y));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.lteq(float32(x), float32(y));            
            else if(typeof(T) == typeof(double))
                return fpsinx.lteq(float32(x), float32(y));
            else                
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        public static bool ngt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.ngt(float32(x), float32(y));            
            else if(typeof(T) == typeof(double))
                return fpsinx.ngt(float32(x), float32(y));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool nlt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.nlt(float32(x), float32(y));            
            else if(typeof(T) == typeof(double))
                return fpsinx.nlt(float32(x), float32(y));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.gt(float32(x), float32(y));
            else if(typeof(T) == typeof(double))
                return fpsinx.gt(float64(x), float64(y));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.gteq(float32(x), float32(y));
            else if(typeof(T) == typeof(double))
                return fpsinx.gteq(float64(x), float64(y));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.lt(float32(x), float32(y));
            else if(typeof(T) == typeof(double))
                return fpsinx.lt(float64(x), float64(y));
            throw unsupported<T>();
        }   

        [MethodImpl(Inline)]
        public static Vector128<T> cmp<T>(Vector128<T> x, Vector128<T> y, FpCmpMode mode)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.cmp(float32(x), float32(y),mode));
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.cmp(float64(x), float64(y),mode));
            throw unsupported<T>();
        }   

    }
}