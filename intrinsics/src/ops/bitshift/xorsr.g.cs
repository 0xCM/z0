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
        /// <param name="count">The amount by which to shift each component</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vxorsr<T>(Vector128<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vxorsr(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vxorsr(v16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vxorsr(v32u(x), count));
            else if(typeof(T) == typeof(ulong)) 
                return vgeneric<T>(dinx.vxorsr(v64u(x), count));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The amount by which to shift each component</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vxorsr<T>(Vector256<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vxorsr(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vxorsr(v16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vxorsr(v32u(x), count));
            else if(typeof(T) == typeof(ulong)) 
                return vgeneric<T>(dinx.vxorsr(v64u(x), count));
            else
                throw unsupported<T>();
        }
    }
}