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
    /// Generic scalar intrinsics over floating-point domains
    /// </summary>
    public static class ginxsfp
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
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

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static T store<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinxsfp.store(v32f(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinxsfp.store(v64f(src)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> add<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.add(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.add(v64f(x), v64f(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> sub<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.sub(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.sub(v64f(x), v64f(y)));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> mul<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.mul(v32f(x), v32f(y)));          
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.mul(v64f(x), v64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> div<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.div(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.div(v64f(x), v64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> min<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.min(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.min(v64f(x), v64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> max<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.max(v32f(x), v32f(y)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.max(v64f(x), v64f(y)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> ceil<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.ceil(v32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.ceil(v64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> floor<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.floor(v32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.floor(v64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> sqrt<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.sqrt(v32f(x)));            
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.sqrt(v64f(x)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> fmadd<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.fmadd(v32f(x), v32f(y), v32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.fmadd(v64f(x), v64f(y), v64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> fmsub<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.fmsub(v32f(x), v32f(y), v32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.fmsub(v64f(x), v64f(y), v64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> fnmadd<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.fnmadd(v32f(x), v32f(y), v32f(z))); 
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.fnmadd(v64f(x), v64f(y), v64f(z)));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static bool eq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.eq(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return dinxsfp.eq(v64f(x), v64f(y));
            throw 
                unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static bool neq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.neq(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return dinxsfp.neq(v64f(x), v64f(y));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static bool lteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.lteq(v32f(x), v32f(y));            
            else if(typeof(T) == typeof(double))
                return dinxsfp.lteq(v32f(x), v32f(y));
            else                
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static bool ngt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.ngt(v32f(x), v32f(y));            
            else if(typeof(T) == typeof(double))
                return dinxsfp.ngt(v32f(x), v32f(y));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static bool nlt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.nlt(v32f(x), v32f(y));            
            else if(typeof(T) == typeof(double))
                return dinxsfp.nlt(v32f(x), v32f(y));
            else                
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static bool gt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.gt(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return dinxsfp.gt(v64f(x), v64f(y));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static bool gteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.gteq(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return dinxsfp.gteq(v64f(x), v64f(y));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static bool lt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinxsfp.lt(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return dinxsfp.lt(v64f(x), v64f(y));
            throw unsupported<T>();
        }   

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Floats)]
        public static Vector128<T> cmp<T>(Vector128<T> x, Vector128<T> y, FpCmpMode mode)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinxsfp.cmp(v32f(x), v32f(y),mode));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinxsfp.cmp(v64f(x), v64f(y),mode));
            throw unsupported<T>();
        }   
    }
}