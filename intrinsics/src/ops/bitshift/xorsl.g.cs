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
        /// <param name="count">The shift offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static Vector128<T> vxorsl<T>(Vector128<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vxorsl(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vxorsl(v16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vxorsl(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vxorsl(v64u(x), count));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes z := x^(x << offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The shift offset</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static Vector256<T> vxorsl<T>(Vector256<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vxorsl(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vxorsl(v16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vxorsl(v32u(x), count));
            else if(typeof(T) == typeof(ulong)) 
                return vgeneric<T>(dinx.vxorsl(v64u(x), count));
            else
                throw unsupported<T>();
        }
    }
}