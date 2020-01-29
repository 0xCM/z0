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
    
    using static zfunc;

    using static As;

    partial class ginx
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vnot<T>(Vector128<T> x)
            where T : unmanaged
                => vnot_u(x);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vnot<T>(Vector256<T> x)
            where T : unmanaged
                => vnot_u(x);

        [MethodImpl(Inline)]
        static Vector128<T> vnot_u<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vnot(v8u(x)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vnot(v16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vnot(v32u(x)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vnot(v64u(x)));
            else
                return vnot_i(x);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnot_i<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vnot(v8i(x)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vnot(v16i(x)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vnot(v32i(x)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vnot(v64i(x)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnot_u<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vnot(v8u(x)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vnot(v16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vnot(v32u(x)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vnot(v64u(x)));
            else
                return vnot_i(x);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnot_i<T>(Vector256<T> x)
            where T : unmanaged
        {
             if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vnot(v8i(x)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vnot(v16i(x)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vnot(v32i(x)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vnot(v64i(x)));
            else
                throw unsupported<T>();
       }
    }
}