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
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector128<T> vinc<T>(Vector128<T> src)
            where T : unmanaged
                => vinc_u(src);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static Vector256<T> vinc<T>(Vector256<T> src)
            where T : unmanaged
                => vinc_u(src);

        [MethodImpl(Inline)]
        static Vector128<T> vinc_u<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vinc(v8u(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vinc(v16u(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vinc(v32u(src)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vinc(v64u(src)));
            else
                return vinc_i(src);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vinc_i<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return vgeneric<T>(dinx.vinc(v8i(src)));
            else if(typeof(T) == typeof(short))
                 return vgeneric<T>(dinx.vinc(v16i(src)));
            else if(typeof(T) == typeof(int))
                 return vgeneric<T>(dinx.vinc(v32i(src)));
            else if(typeof(T) == typeof(long))
                 return vgeneric<T>(dinx.vinc(v64i(src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinc_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vinc(v8u(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vinc(v16u(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vinc(v32u(src)));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vinc(v64u(src)));
            else
                return vinc_i(src);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinc_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return vgeneric<T>(dinx.vinc(v8i(src)));
            else if(typeof(T) == typeof(short))
                 return vgeneric<T>(dinx.vinc(v16i(src)));
            else if(typeof(T) == typeof(int))
                 return vgeneric<T>(dinx.vinc(v32i(src)));
            else if(typeof(T) == typeof(long))
                 return vgeneric<T>(dinx.vinc(v64i(src)));
            else 
                throw unsupported<T>();
        }
    }
}