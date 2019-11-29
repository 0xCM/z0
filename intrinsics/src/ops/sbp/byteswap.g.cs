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
    
    using static As;
    using static zfunc;

    partial class ginx
    {

        [MethodImpl(Inline)]
        public static Vector128<T> vbyteswap<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return x;
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vbyteswap(vcast16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vbyteswap(vcast32u(x)));            
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vbyteswap(vcast64u(x)));            
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vbyteswap<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return x;
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vbyteswap(vcast16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vbyteswap(vcast32u(x)));            
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vbyteswap(vcast64u(x)));            
            else
                throw unsupported<T>();
        }



    }

}