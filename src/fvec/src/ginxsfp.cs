//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static z;

    /// <summary>
    /// Generic scalar intrinsics over floating-point domains
    /// </summary>
    [ApiHost]
    public static class ginxsfp
    {
        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> load<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.vloads(float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.vloads(float64(src)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static T store<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.vstores(v32f(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.vstores(v64f(src)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> add<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.vadds(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.vadds(v64f(x), v64f(y)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> sub<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.sub(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.sub(v64f(x), v64f(y)));
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> mul<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.vmuls(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.vmuls(v64f(x), v64f(y)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> div<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.div(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.div(v64f(x), v64f(y)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> min<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.min(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.min(v64f(x), v64f(y)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> max<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.max(v32f(x), v32f(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.max(v64f(x), v64f(y)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> ceil<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.ceil(v32f(x)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.ceil(v64f(x)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> floor<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.floor(v32f(x)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.floor(v64f(x)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> sqrt<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.sqrt(v32f(x)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.sqrt(v64f(x)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> fmadd<T>(Vector128<T> x, Vector128<T> y, Vector128<T> z)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinxsfp.fmadd(v32f(x), v32f(y), v32f(z)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinxsfp.fmadd(v64f(x), v64f(y), v64f(z)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> fmsub<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.fmsub(v32f(a), v32f(b), v32f(c)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.fmsub(v64f(a), v64f(b), v64f(c)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> fnmadd<T>(Vector128<T> a, Vector128<T> b, Vector128<T> c)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.fnmadd(v32f(a), v32f(b), v32f(c)));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.fnmadd(v64f(a), v64f(b), v64f(c)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static bool eq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.eq(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return z.eq(v64f(x), v64f(y));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static bool neq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.neq(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return z.neq(v64f(x), v64f(y));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static bool lteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.lteq(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return z.lteq(v32f(x), v32f(y));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static bool ngt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.ngt(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return z.ngt(v32f(x), v32f(y));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static bool nlt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.nlt(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return z.nlt(v32f(x), v32f(y));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static bool gt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.gt(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return z.gt(v64f(x), v64f(y));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static bool gteq<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.gteq(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return z.gteq(v64f(x), v64f(y));
            else
                throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static bool lt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return z.lt(v32f(x), v32f(y));
            else if(typeof(T) == typeof(double))
                return z.lt(v64f(x), v64f(y));
            throw no<T>();
        }

        [MethodImpl(Inline), Op, Closures(Floats)]
        public static Vector128<T> cmp<T>(Vector128<T> x, Vector128<T> y, FpCmpMode mode)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(z.cmp(v32f(x), v32f(y),mode));
            else if(typeof(T) == typeof(double))
                return generic<T>(z.cmp(v64f(x), v64f(y),mode));
            throw no<T>();
        }
    }
}