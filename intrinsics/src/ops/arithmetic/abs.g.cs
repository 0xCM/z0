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
        public static Vector128<T> vabs<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vabs(vcast8i(x)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vabs(vcast16i(x)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vabs(vcast32i(x)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vabs(vcast64i(x)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vabs<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vabs(vcast8i(x)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vabs(vcast16i(x)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vabs(vcast32i(x)));
            else if(typeof(T) == typeof(long))
                return vgeneric<T>(dinx.vabs(vcast64i(x)));
            else
                throw unsupported<T>();
        }
    }
}