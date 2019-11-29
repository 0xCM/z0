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
    using static AsIn;
    
    partial class ginx
    {    
        
        [MethodImpl(Inline)]
        public static Vector128<T> vsrl<T>(Vector128<T> x, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vsrl(vcast8u(x), offset));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrl(vcast16u(x), offset));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrl(vcast32u(x), offset));
            else 
                return vgeneric<T>(dinx.vsrl(vcast64u(x), offset));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsrl<T>(Vector256<T> x, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrl(vcast8u(x), offset));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrl(vcast16u(x), offset));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrl(vcast32u(x), offset));
            else 
                return vgeneric<T>(dinx.vsrl(vcast64u(x), offset));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsrl<T>(Vector256<T> x, Vector128<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsrl_u(x,offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsrl_i(x,offset);
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrl_i<T>(Vector256<T> x, Vector128<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vsrl(vcast8i(x), vcast8i(offset)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vsrl(vcast16i(x), vcast16i(offset)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vsrl(vcast32i(x), vcast32i(offset)));
            else 
                return vgeneric<T>(dinx.vsrl(vcast64i(x), vcast64i(offset)));            
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrl_u<T>(Vector256<T> x, Vector128<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrl(vcast8u(x), vcast8u(offset)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrl(vcast16u(x), vcast16u(offset)));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrl(vcast32u(x), vcast32u(offset)));
            else 
                return vgeneric<T>(dinx.vsrl(vcast64u(x), vcast64u(offset)));
        }

    }
}