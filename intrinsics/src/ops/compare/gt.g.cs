//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        public static Vector128<T> vgt<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vgt_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vgt_i(x,y);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vgt<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vgt_u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vgt_i(x,y);
            else
                throw unsupported<T>();
        }

 
        [MethodImpl(Inline)]
        static Vector128<T> vgt_i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return As.vgeneric<T>(dinx.vgt(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                 return As.vgeneric<T>(dinx.vgt(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vgt(vcast32i(x), vcast32i(y)));
            else
                 return generic<T>(dinx.vgt(vcast64i(x), vcast64i(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vgt_u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vgt(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vgt(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vgt(vcast32u(x), vcast32u(y)));
            else 
                return generic<T>(dinx.vgt(vcast64u(x), vcast64u(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vgt_i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vgt(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vgt(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vgt(vcast32i(x), vcast32i(y)));
            else
                 return generic<T>(dinx.vgt(vcast64i(x), vcast64i(y)));
        }    

        [MethodImpl(Inline)]
        static Vector256<T> vgt_u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vgt(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vgt(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vgt(vcast32u(x), vcast32u(y)));
            else 
                return generic<T>(dinx.vgt(vcast64u(x), vcast64u(y)));
        }    
    }
}