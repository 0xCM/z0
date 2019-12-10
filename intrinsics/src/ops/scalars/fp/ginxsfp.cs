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
    /// Generic scalar floating-point intrinsics
    /// </summary>
    public static class ginxsfp
    {

        [MethodImpl(Inline)]
        public static Vector128<T> load<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.load(float32(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.load(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T store<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(inxsfp.store(vcast32f(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(inxsfp.store(vcast64f(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> add<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.add(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.add(vcast64f(x), vcast64f(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> sub<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.sub(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.sub(vcast64f(x), vcast64f(y)));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> mul<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.mul(vcast32f(x), vcast32f(y)));          
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.mul(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> div<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.div(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.div(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> min<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.min(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.min(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> max<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.max(vcast32f(x), vcast32f(y)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.max(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> ceil<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.ceil(vcast32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.ceil(vcast64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> floor<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.floor(vcast32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.floor(vcast64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> sqrt<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.sqrt(vcast32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.sqrt(vcast64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fmadd<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.fmadd(vcast32f(x), vcast32f(y), vcast32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.fmadd(vcast64f(x), vcast64f(y), vcast64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fmsub<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.fmsub(vcast32f(x), vcast32f(y), vcast32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.fmsub(vcast64f(x), vcast64f(y), vcast64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fnmadd<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.fnmadd(vcast32f(x), vcast32f(y), vcast32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.fnmadd(vcast64f(x), vcast64f(y), vcast64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool eq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxsfp.eq(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return inxsfp.eq(vcast64f(x), vcast64f(y));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool neq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxsfp.neq(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return inxsfp.neq(vcast64f(x), vcast64f(y));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxsfp.lteq(vcast32f(x), vcast32f(y));            
            else if(typeof(T) == typeof(double))
                return inxsfp.lteq(vcast32f(x), vcast32f(y));
            else                
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        public static bool ngt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxsfp.ngt(vcast32f(x), vcast32f(y));            
            else if(typeof(T) == typeof(double))
                return inxsfp.ngt(vcast32f(x), vcast32f(y));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool nlt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxsfp.nlt(vcast32f(x), vcast32f(y));            
            else if(typeof(T) == typeof(double))
                return inxsfp.nlt(vcast32f(x), vcast32f(y));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxsfp.gt(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return inxsfp.gt(vcast64f(x), vcast64f(y));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxsfp.gteq(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return inxsfp.gteq(vcast64f(x), vcast64f(y));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return inxsfp.lt(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return inxsfp.lt(vcast64f(x), vcast64f(y));
            throw unsupported<T>();
        }   

        [MethodImpl(Inline)]
        public static Vector128<T> cmp<T>(Vector128<T> x, Vector128<T> y, FpCmpMode mode)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(inxsfp.cmp(vcast32f(x), vcast32f(y),mode));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(inxsfp.cmp(vcast64f(x), vcast64f(y),mode));
            throw unsupported<T>();
        }   

    }
}