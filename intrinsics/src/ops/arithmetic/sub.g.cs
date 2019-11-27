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
    using static System.Runtime.Intrinsics.X86.Avx2;
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Sse2;
    using static System.Runtime.Intrinsics.X86.Sse;
    
    
    using static zfunc;
    using static As;
    

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vector128<T> vsub<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsubu(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsubi(x,y);
            else return gfpv.vadd(x,y);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsub<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vsubu(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vsubi(x,y);
            else return gfpv.vadd(x,y);
       }

             
        [MethodImpl(Inline)]
        static Vector128<T> vsubi<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return As.vgeneric<T>(dinx.vsub(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                 return As.vgeneric<T>(dinx.vsub(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vsub(vcast32i(x), vcast32i(y)));
            else
                 return generic<T>(dinx.vsub(vcast64i(x), vcast64i(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsubu<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vsub(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsub(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vsub(vcast32u(x), vcast32u(y)));
            else 
                return generic<T>(dinx.vsub(vcast64u(x), vcast64u(y)));
        }


        [MethodImpl(Inline)]
        static Vector256<T> vsubi<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return generic<T>(dinx.vsub(vcast8i(x), vcast8i(y)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(dinx.vsub(vcast16i(x), vcast16i(y)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(dinx.vsub(vcast32i(x), vcast32i(y)));
            else
                 return generic<T>(dinx.vsub(vcast64i(x), vcast64i(y)));
        }    


        [MethodImpl(Inline)]
        static Vector256<T> vsubu<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vsub(vcast8u(x), vcast8u(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vsub(vcast16u(x), vcast16u(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vsub(vcast32u(x), vcast32u(y)));
            else 
                return generic<T>(dinx.vsub(vcast64u(x), vcast64u(y)));
        }    
    }
}