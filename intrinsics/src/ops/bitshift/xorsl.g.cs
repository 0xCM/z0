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
        /// Computes z := x^(x << offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">The shift offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInts)]
        public static Vector128<T> vxorsl<T>(Vector128<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vxorsl(v8u(x), shift));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vxorsl(v16u(x), shift));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vxorsl(v32u(x), shift));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vxorsl(v64u(x), shift));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes z := x^(x << offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">The shift offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInts)]
        public static Vector256<T> vxorsl<T>(Vector256<T> x, byte shift)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vxorsl(v8u(x), shift));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vxorsl(v16u(x), shift));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vxorsl(v32u(x), shift));
            else if(typeof(T) == typeof(ulong)) 
                return vgeneric<T>(dinx.vxorsl(v64u(x), shift));
            else
                throw unsupported<T>();
        }
    }
}