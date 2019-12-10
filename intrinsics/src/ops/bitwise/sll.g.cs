//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    using static As;
    
    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vector128<T> vsll<T>(Vector128<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsll_u(x,shift);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsll_i(x,shift);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsll<T>(Vector256<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsll_u(x,shift);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsll_i(x,shift);
            else
                throw unsupported<T>();
        }



        [MethodImpl(Inline)]
        static Vector128<T> vsll_i<T>(Vector128<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(dinx.vsll(vcast8i(x), shift));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(dinx.vsll(vcast16i(x), shift));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsll(vcast32i(x), shift));
            else 
                return vgeneric<T>(dinx.vsll(vcast64i(x), shift));            
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsll_u<T>(Vector128<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vsll(vcast8u(x), shift));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsll(vcast16u(x), shift));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsll(vcast32u(x), shift));
            else 
                return vgeneric<T>(dinx.vsll(vcast64u(x), shift));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_i<T>(Vector256<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsll(vcast8i(x), shift));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsll(vcast16i(x), shift));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsll(vcast32i(x), shift));
            else 
                return vgeneric<T>(dinx.vsll(vcast64i(x), shift));            
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_u<T>(Vector256<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsll(vcast8u(x), shift));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsll(vcast16u(x), shift));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsll(vcast32u(x), shift));
            else 
                return vgeneric<T>(dinx.vsll(vcast64u(x), shift));
        }
    }
}