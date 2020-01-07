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
        [MethodImpl(Inline), ZFunc(PrimalKind.Integral)]
        public static Vector128<T> vinc<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vinc_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vinc_i(src);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline), ZFunc(PrimalKind.Integral)]
        public static Vector256<T> vinc<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vinc_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vinc_i(src);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vinc_i<T>(Vector128<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return As.vgeneric<T>(dinx.vinc(v8i(lhs)));
            else if(typeof(T) == typeof(short))
                 return As.vgeneric<T>(dinx.vinc(v16i(lhs)));
            else if(typeof(T) == typeof(int))
                 return vgeneric<T>(dinx.vinc(v32i(lhs)));
            else
                 return vgeneric<T>(dinx.vinc(v64i(lhs)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vinc_u<T>(Vector128<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vinc(v8u(lhs)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vinc(v16u(lhs)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vinc(v32u(lhs)));
            else 
                return vgeneric<T>(dinx.vinc(v64u(lhs)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinc_i<T>(Vector256<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return vgeneric<T>(dinx.vinc(v8i(lhs)));
            else if(typeof(T) == typeof(short))
                 return vgeneric<T>(dinx.vinc(v16i(lhs)));
            else if(typeof(T) == typeof(int))
                 return vgeneric<T>(dinx.vinc(v32i(lhs)));
            else
                 return vgeneric<T>(dinx.vinc(v64i(lhs)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vinc_u<T>(Vector256<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vinc(v8u(lhs)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vinc(v16u(lhs)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vinc(v32u(lhs)));
            else 
                return vgeneric<T>(dinx.vinc(v64u(lhs)));
        }
    }
}