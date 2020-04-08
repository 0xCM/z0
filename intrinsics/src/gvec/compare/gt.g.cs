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
    
    using static Core;
    using static Gone2;

    partial class gvec
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static Vector128<T> vgt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => vgt_u(x,y);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static Vector256<T> vgt<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => vgt_u(x,y);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static Vector512<T> vgt<T>(in Vector512<T> x, in Vector512<T> y)
            where T : unmanaged
                => (vgt(x.Lo, y.Lo), vgt(x.Hi, y.Hi));

        [MethodImpl(Inline)]
        static Vector128<T> vgt_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vgt(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vgt(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vgt(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vgt(v64u(x), v64u(y)));
            else
                return vgt_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vgt_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dvec.vgt(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dvec.vgt(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dvec.vgt(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(dvec.vgt(v64i(x), v64i(y)));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vgt_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dvec.vgt(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dvec.vgt(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dvec.vgt(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dvec.vgt(v64u(x), v64u(y)));
            else
                return vgt_i(x,y);
        }    

        [MethodImpl(Inline)]
        static Vector256<T> vgt_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dvec.vgt(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dvec.vgt(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dvec.vgt(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(dvec.vgt(v64i(x), v64i(y)));
            else
                throw Unsupported.define<T>();
        }    

    }
}