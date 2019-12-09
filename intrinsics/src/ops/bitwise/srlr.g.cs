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
        public static Vector128<T> vsrlr<T>(Vector128<T> x, Vector128<T> shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsrlr_u(x,shift);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsrlr_i(x,shift);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsrlr<T>(Vector256<T> x, Vector128<T> shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsrlr_u(x,shift);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsrlr_i(x,shift);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vsrlr<T>(Vector128<T> x, T shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsrlr_u(x,shift);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsrlr_i(x,shift);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsrlr<T>(Vector256<T> x, T shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsrlr_u(x,shift);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsrlr_i(x,shift);
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_i<T>(Vector128<T> x, Vector128<T> shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrlr(vcast16i(x), vcast16i(shift)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsrlr(vcast32i(x), vcast32i(shift)));
            else 
                return vgeneric<T>(dinx.vsrlr(vcast64i(x), vcast64i(shift)));            
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_u<T>(Vector128<T> x, Vector128<T> shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrlr(vcast16u(x), vcast16u(shift)));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrlr(vcast32u(x), vcast32u(shift)));
            else 
                return vgeneric<T>(dinx.vsrlr(vcast64u(x), vcast64u(shift)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_i<T>(Vector128<T> x, T shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrlr(vcast16i(x), int16(shift)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsrlr(vcast32i(x), int32(shift)));
            else 
                return vgeneric<T>(dinx.vsrlr(vcast64i(x), int64(shift)));            
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_u<T>(Vector128<T> x, T shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrlr(vcast16u(x), uint16(shift)));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrlr(vcast32u(x), uint32(shift)));
            else 
                return vgeneric<T>(dinx.vsrlr(vcast64u(x), uint64(shift)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_i<T>(Vector256<T> x, T shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrlr(vcast16i(x), int16(shift)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsrlr(vcast32i(x), int32(shift)));
            else 
                return vgeneric<T>(dinx.vsrlr(vcast64i(x), int64(shift)));            
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_u<T>(Vector256<T> x, T shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrlr(vcast16u(x), uint16(shift)));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrlr(vcast32u(x), uint32(shift)));
            else 
                return vgeneric<T>(dinx.vsrlr(vcast64u(x), uint64(shift)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_i<T>(Vector256<T> x, Vector128<T> shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsrlr(vcast8i(x), vcast8i(shift)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrlr(vcast16i(x), vcast16i(shift)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsrlr(vcast32i(x), vcast32i(shift)));
            else 
                return vgeneric<T>(dinx.vsrlr(vcast64i(x), vcast64i(shift)));            
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_u<T>(Vector256<T> x, Vector128<T> shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrlr(vcast8u(x), vcast8u(shift)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrlr(vcast16u(x), vcast16u(shift)));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrlr(vcast32u(x), vcast32u(shift)));
            else 
                return vgeneric<T>(dinx.vsrlr(vcast64u(x), vcast64u(shift)));
        }

    }
}