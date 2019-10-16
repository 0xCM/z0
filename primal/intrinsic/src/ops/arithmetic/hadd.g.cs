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
        public static Vector128<T> vhadd<T>(Vector128<T> lhs, Vector128<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(short))
                return generic<T>(dinx.vhadd(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vhadd(int32(lhs), int32(rhs)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vhadd<T>(Vector256<T> lhs, Vector256<T> rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(short))
                return generic<T>(dinx.vhadd(int16(lhs), int16(rhs)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vhadd(int32(lhs), int32(rhs)));
            else 
                throw unsupported<T>();
        }
        
   }
}