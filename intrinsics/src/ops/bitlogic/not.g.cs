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
        [MethodImpl(Inline)]
        public static Vector128<T> vnot<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnot_u(x);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnot_i(x);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnot<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnot_u(x);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnot_i(x);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnot_u<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vnot(vcast8u(x)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vnot(vcast16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vnot(vcast32u(x)));
            else
                return vgeneric<T>(dinx.vnot(vcast64u(x)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnot_i<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(dinx.vnot(vcast8i(x)));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(dinx.vnot(vcast16i(x)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vnot(vcast32i(x)));
            else
                return vgeneric<T>(dinx.vnot(vcast64i(x)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnot_u<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vnot(vcast8u(x)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vnot(vcast16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vnot(vcast32u(x)));
            else
                return vgeneric<T>(dinx.vnot(vcast64u(x)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnot_i<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vnot(vcast8i(x)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vnot(vcast16i(x)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vnot(vcast32i(x)));
            else
                return vgeneric<T>(dinx.vnot(vcast64i(x)));
        }
    }
}