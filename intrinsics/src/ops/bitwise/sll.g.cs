//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;
    using static As;
    using static AsIn;
    
    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vector128<T> vsll<T>(Vector128<T> x, int shift)
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
        public static Vector256<T> vsll<T>(Vector256<T> x, int shift)
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
        public static Vector256<T> vsll<T>(Vector256<T> x, Vector128<T> shift)
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
        static Vector128<T> vsll_i<T>(Vector128<T> x, int shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(dinx.vsll(vcast8i(x), shift));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(dinx.vsll(vcast16i(x), shift));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vsll(vcast32i(x), shift));
            else 
                return generic<T>(dinx.vsll(vcast64i(x), shift));            
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsll_u<T>(Vector128<T> x, int shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vsll(vcast8u(x), shift));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsll(vcast16u(x), shift));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsll(vcast32u(x), shift));
            else 
                return generic<T>(dinx.vsll(vcast64u(x), shift));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_i<T>(Vector256<T> x, int shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vsll(vcast8i(x), shift));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vsll(vcast16i(x), shift));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vsll(vcast32i(x), shift));
            else 
                return generic<T>(dinx.vsll(vcast64i(x), shift));            
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_u<T>(Vector256<T> x, int shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsll(vcast8u(x), shift));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsll(vcast16u(x), shift));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsll(vcast32u(x), shift));
            else 
                return generic<T>(dinx.vsll(vcast64u(x), shift));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_i<T>(Vector256<T> x, Vector128<T> shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vsll(vcast8i(x), vcast8i(shift)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vsll(vcast16i(x), vcast16i(shift)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vsll(vcast32i(x), vcast32i(shift)));
            else 
                return generic<T>(dinx.vsll(vcast64i(x), vcast64i(shift)));            
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_u<T>(Vector256<T> x, Vector128<T> shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsll(vcast8u(x), vcast8u(shift)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsll(vcast16u(x), vcast16u(shift)));
            else if(typeof(T) == typeof(uint)) 
                return generic<T>(dinx.vsll(vcast32u(x), vcast32u(shift)));
            else 
                return generic<T>(dinx.vsll(vcast64u(x), vcast64u(shift)));
        }

    }
}