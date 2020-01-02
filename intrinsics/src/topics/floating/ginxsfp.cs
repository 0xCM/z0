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
    using static AsIn;
    using static zfunc;    
    
    /// <summary>
    /// Generic scalar floating-point intrinsics
    /// </summary>
    public static partial class ginxsfp
    {

        [MethodImpl(Inline)]
        public static Vector128<T> load<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.load(float32(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.load(float64(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static T store<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinxsfp.store(vcast32f(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinxsfp.store(vcast64f(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> add<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.add(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.add(vcast64f(x), vcast64f(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> sub<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.sub(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.sub(vcast64f(x), vcast64f(y)));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> mul<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.mul(vcast32f(x), vcast32f(y)));          
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.mul(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> div<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.div(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.div(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> min<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.min(vcast32f(x), vcast32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.min(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> max<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.max(vcast32f(x), vcast32f(y)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.max(vcast64f(x), vcast64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> ceil<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.ceil(vcast32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.ceil(vcast64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> floor<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.floor(vcast32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.floor(vcast64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> sqrt<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.sqrt(vcast32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.sqrt(vcast64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fmadd<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.fmadd(vcast32f(x), vcast32f(y), vcast32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.fmadd(vcast64f(x), vcast64f(y), vcast64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fmsub<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.fmsub(vcast32f(x), vcast32f(y), vcast32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.fmsub(vcast64f(x), vcast64f(y), vcast64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> fnmadd<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.fnmadd(vcast32f(x), vcast32f(y), vcast32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.fnmadd(vcast64f(x), vcast64f(y), vcast64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool eq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.eq(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return dinxsfp.eq(vcast64f(x), vcast64f(y));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool neq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.neq(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return dinxsfp.neq(vcast64f(x), vcast64f(y));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.lteq(vcast32f(x), vcast32f(y));            
            else if(typeof(T) == typeof(double))
                return dinxsfp.lteq(vcast32f(x), vcast32f(y));
            else                
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        public static bool ngt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.ngt(vcast32f(x), vcast32f(y));            
            else if(typeof(T) == typeof(double))
                return dinxsfp.ngt(vcast32f(x), vcast32f(y));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool nlt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.nlt(vcast32f(x), vcast32f(y));            
            else if(typeof(T) == typeof(double))
                return dinxsfp.nlt(vcast32f(x), vcast32f(y));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.gt(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return dinxsfp.gt(vcast64f(x), vcast64f(y));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.gteq(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return dinxsfp.gteq(vcast64f(x), vcast64f(y));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static bool lt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.lt(vcast32f(x), vcast32f(y));
            else if(typeof(T) == typeof(double))
                return dinxsfp.lt(vcast64f(x), vcast64f(y));
            throw unsupported<T>();
        }   

        [MethodImpl(Inline)]
        public static Vector128<T> cmp<T>(Vector128<T> x, Vector128<T> y, FpCmpMode mode)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.cmp(vcast32f(x), vcast32f(y),mode));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.cmp(vcast64f(x), vcast64f(y),mode));
            throw unsupported<T>();
        }   

    }
}