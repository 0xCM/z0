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
    
    using static Root;
    using static gvec;

    using static As;

    partial class ginx
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static Vector128<T> vlt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
                => vlt_u(x,y);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static Vector256<T> vlt<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
                => vlt_u(x,y);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers& (~NumericKind.U64))]
        public static Vector512<T> vlt<T>(in Vector512<T> x, in Vector512<T> y)
            where T : unmanaged
                => (vlt(x.Lo, y.Lo), vlt(x.Hi, y.Hi));

        [MethodImpl(Inline)]
        static Vector128<T> vlt_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vlt(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vlt(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vlt(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vlt(v64u(x), v64u(y)));
            else
                return vlt_i(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vlt_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vlt(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vlt(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vlt(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(dinx.vlt(v64i(x), v64i(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vlt_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vlt(v8u(x), v8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vlt(v16u(x), v16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vlt(v32u(x), v32u(y)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vlt(v64u(x), v64u(y)));
            else
                return vlt_i(x,y);
        }    

        [MethodImpl(Inline)]
        static Vector256<T> vlt_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vlt(v8i(x), v8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vlt(v16i(x), v16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vlt(v32i(x), v32i(y)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(dinx.vlt(v64i(x), v64i(y)));
            else
                throw unsupported<T>();
        }    
    }
}