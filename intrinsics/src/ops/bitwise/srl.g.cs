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
        public static Vector128<T> vsrl<T>(Vector128<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrl(vcast8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrl(vcast16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrl(vcast32u(x), count));
            else 
                return vgeneric<T>(dinx.vsrl(vcast64u(x), count));
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vsrl<T>(Vector256<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vsrl(vcast8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vsrl(vcast16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vsrl(vcast32u(x), count));
            else 
                return vgeneric<T>(dinx.vsrl(vcast64u(x), count));
        }
    }
}