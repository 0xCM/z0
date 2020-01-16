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
    
    using static zfunc;    

    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Rotates each component the source vector leftwards by a constant amount
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static Vector128<T> vrotl<T>(Vector128<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vrotl(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vrotl(v16u(x), count));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vrotl(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vrotl(v64u(x), count));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by a constant count
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.UnsignedInts)]
        public static Vector256<T> vrotl<T>(Vector256<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vrotl(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vrotl(v16u(x), count));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vrotl(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vrotl(v64u(x), count));
            else
                throw unsupported<T>();
        }
    }
}