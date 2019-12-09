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
        public static Vector128<T> vsrl<T>(Vector128<T> x, byte offset)
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
        public static Vector256<T> vsrl<T>(Vector256<T> x, byte offset)
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


    }
}