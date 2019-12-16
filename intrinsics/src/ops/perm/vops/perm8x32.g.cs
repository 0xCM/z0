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
    
    using static As;
    using static zfunc;

    partial class ginx
    {
        /// <summary>
        /// Applies a cross-lane permutation over 8 32-bit segments in the source vector as indicated by the perm spec
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="spec">The perm spec</param>
        /// <typeparam name="T">The vector component type</typeparam>
        public static Vector256<T> vperm8x32<T>(Vector256<T> x, Vector256<uint> spec)        
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(v8u(dinx.vperm8x32(v32u(x), spec)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(v16u(dinx.vperm8x32(v32u(x), spec)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vperm8x32(vcast32u(x), spec));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(v64u(dinx.vperm8x32(v32u(x), spec)));
            else
                throw unsupported<T>();
        }
    }
}