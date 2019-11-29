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
                return vgeneric<T>(fpsinx.load(float32(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.load(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T store<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(fpsinx.store(vcast32f(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(fpsinx.store(vcast64f(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> add<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.add(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.add(vcast64f(x), vcast64f(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> sub<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.sub(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.sub(vcast64f(x), vcast64f(y)));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> mul<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.mul(vcast32f(x), vcast32f(y)));          
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.mul(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> div<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.div(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.div(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> min<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.min(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.min(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> max<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.max(vcast32f(x), vcast32f(y)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.max(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> ceil<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.ceil(vcast32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.ceil(vcast64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> floor<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.floor(vcast32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.floor(vcast64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> sqrt<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.sqrt(vcast32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.sqrt(vcast64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fmadd<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.fmadd(vcast32f(x), vcast32f(y), vcast32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.fmadd(vcast64f(x), vcast64f(y), vcast64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fmsub<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.fmsub(vcast32f(x), vcast32f(y), vcast32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.fmsub(vcast64f(x), vcast64f(y), vcast64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fnmadd<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.fnmadd(vcast32f(x), vcast32f(y), vcast32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.fnmadd(vcast64f(x), vcast64f(y), vcast64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool eq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.eq(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return fpsinx.eq(vcast64f(x), vcast64f(y));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool neq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.neq(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return fpsinx.neq(vcast64f(x), vcast64f(y));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.lteq(vcast32f(x), vcast32f(y));            
            else if(typeof(T) == typeof(double))
                return fpsinx.lteq(vcast32f(x), vcast32f(y));
            else                
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        public static bool ngt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.ngt(vcast32f(x), vcast32f(y));            
            else if(typeof(T) == typeof(double))
                return fpsinx.ngt(vcast32f(x), vcast32f(y));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool nlt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.nlt(vcast32f(x), vcast32f(y));            
            else if(typeof(T) == typeof(double))
                return fpsinx.nlt(vcast32f(x), vcast32f(y));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.gt(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return fpsinx.gt(vcast64f(x), vcast64f(y));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.gteq(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return fpsinx.gteq(vcast64f(x), vcast64f(y));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fpsinx.lt(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return fpsinx.lt(vcast64f(x), vcast64f(y));
            throw unsupported<T>();
        }   

        [MethodImpl(Inline)]
        public static Vector128<T> cmp<T>(Vector128<T> x, Vector128<T> y, FpCmpMode mode)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpsinx.cmp(vcast32f(x), vcast32f(y),mode));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpsinx.cmp(vcast64f(x), vcast64f(y),mode));
            throw unsupported<T>();
        }   

    }
}