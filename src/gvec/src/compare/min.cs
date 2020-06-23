//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Konst; 
    using static As;

    partial class gvec
    {        
        [MethodImpl(Inline), Min, Closures(AllNumeric & (~NumericKind.U64))]
        public static Vector128<T> vmin<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => vmin_u(x,y);
         
        [MethodImpl(Inline), Min, Closures(AllNumeric & (~NumericKind.U64))]
        public static Vector256<T> vmin<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => vmin_u(x,y);

        [MethodImpl(Inline)]
        static Vector128<T> vmin_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vmin(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vmin(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vmin(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vmin(v64u(x), v64u(y)));
            else 
                return vmin_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vmin_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dvec.vmin(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dvec.vmin(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dvec.vmin(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(dvec.vmin(v64i(x), v64i(y)));
            else 
                return ginxfp.vmin(x,y);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vmin_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vmin(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vmin(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vmin(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vmin(v64u(x), v64u(y)));
            else 
                return vmin_i(x,y);
        } 

        [MethodImpl(Inline)]
        static Vector256<T> vmin_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dvec.vmin(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dvec.vmin(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dvec.vmin(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(dvec.vmin(v64i(x), v64i(y)));
            else 
                return ginxfp.vmin(x,y);
        }
    }
}