//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;
    
    partial class ginx
    {            
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Integers)]
        public static Vector128<T> vsrl<T>(Vector128<T> x, byte count)
            where T : unmanaged
                => vsrl_u(x,count);

        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.Integers)]
        public static Vector256<T> vsrl<T>(Vector256<T> x, byte count)
            where T : unmanaged
                => vsrl_u(x,count);

        [MethodImpl(Inline)]
        static Vector128<T> vsrl_u<T>(Vector128<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrl(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrl(v16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrl(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vsrl(v64u(x), count));
            else
                return vsrl_i(x,count);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrl_i<T>(Vector128<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsrl(v8i(x), count));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrl(v16i(x), count));
            else if(typeof(T) == typeof(int)) 
                return vgeneric<T>(dinx.vsrl(v32i(x), count));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vsrl(v64i(x), count));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrl_u<T>(Vector256<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrl(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrl(v16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrl(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vsrl(v64u(x), count));
            else
                return vsrl_i(x,count);
       }

        [MethodImpl(Inline)]
        static Vector256<T> vsrl_i<T>(Vector256<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsrl(v8i(x), count));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrl(v16i(x), count));
            else if(typeof(T) == typeof(int)) 
                return vgeneric<T>(dinx.vsrl(v32i(x), count));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vsrl(v64i(x), count));
            else
                throw unsupported<T>();
        }
    }
}