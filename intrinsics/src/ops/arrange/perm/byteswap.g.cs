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
        /// Effects the reversal of the byte-level representation of each component in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.U16 | NumericKind.U32 | NumericKind.U64)]
        public static Vector128<T> vbyteswap<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return x;
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vbyteswap(v16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vbyteswap(v32u(x)));            
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vbyteswap(v64u(x)));            
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Effects the reversal of the byte-level representation of each component in the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op, PrimalClosures(NumericKind.U16 | NumericKind.U32 | NumericKind.U64)]
        public static Vector256<T> vbyteswap<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return x;
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vbyteswap(v16u(x)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vbyteswap(v32u(x)));            
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vbyteswap(v64u(x)));            
            else
                throw unsupported<T>();
        }
    }
}