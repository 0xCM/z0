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
        public static Vector128<T> vdec<T>(Vector128<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vdec_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vdec_i(src);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vdec<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vdec_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vdec_i(src);
            else 
                throw unsupported<T>();
        }

                    
        [MethodImpl(Inline)]
        static Vector128<T> vdec_i<T>(Vector128<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return As.vgeneric<T>(dinx.vdec(vcast8i(lhs)));
            else if(typeof(T) == typeof(short))
                 return As.vgeneric<T>(dinx.vdec(vcast16i(lhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vdec(vcast32i(lhs)));
            else
                 return generic<T>(dinx.vdec(vcast64i(lhs)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vdec_u<T>(Vector128<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vdec(vcast8u(lhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vdec(vcast16u(lhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vdec(vcast32u(lhs)));
            else 
                return generic<T>(dinx.vdec(vcast64u(lhs)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vdec_i<T>(Vector256<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vdec(vcast8i(lhs)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vdec(vcast16i(lhs)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vdec(vcast32i(lhs)));
            else
                 return generic<T>(dinx.vdec(vcast64i(lhs)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vdec_u<T>(Vector256<T> lhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vdec(vcast8u(lhs)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vdec(vcast16u(lhs)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vdec(vcast32u(lhs)));
            else 
                return generic<T>(dinx.vdec(vcast64u(lhs)));
        }

    }
}