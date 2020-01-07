//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The amount by which to shift each component</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInt)]
        public static Vector128<T> vxorsr<T>(Vector128<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vxorsr(v8u(x), shift));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vxorsr(v16u(x), shift));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vxorsr(v32u(x), shift));
            else if(typeof(T) == typeof(ulong)) 
                return vgeneric<T>(dinx.vxorsr(v64u(x), shift));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The amount by which to shift each component</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInt)]
        public static Vector256<T> vxorsr<T>(Vector256<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vxorsr(v8u(x), shift));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vxorsr(v16u(x), shift));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vxorsr(v32u(x), shift));
            else if(typeof(T) == typeof(ulong)) 
                return vgeneric<T>(dinx.vxorsr(v64u(x), shift));
            else
                throw unsupported<T>();
        }
    }
}