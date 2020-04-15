//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    
    using static Seed; 
    using static Memories;

    partial class gvec
    {
        [MethodImpl(Inline), Abs, Closures(SignedInts)]
        public static Vector128<T> vabs<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dvec.vabs(v8i(x)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dvec.vabs(v16i(x)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dvec.vabs(v32i(x)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dvec.vabs(v64i(x)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline), Abs, Closures(SignedInts)]
        public static Vector256<T> vabs<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dvec.vabs(v8i(x)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dvec.vabs(v16i(x)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dvec.vabs(v32i(x)));
            else if(typeof(T) == typeof(long))
                return generic<T>(dvec.vabs(v64i(x)));
            else
                throw Unsupported.define<T>();
        }
    }
}