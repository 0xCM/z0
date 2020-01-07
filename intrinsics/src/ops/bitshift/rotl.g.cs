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
        /// Rotates each component the source vector leftwards by a constant offset
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInt)]
        public static Vector128<T> vrotl<T>(Vector128<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vrotl(v8u(x), offset));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vrotl(v16u(x), offset));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vrotl(v32u(x), offset));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vrotl(v64u(x), offset));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by a constant offset
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInt)]
        public static Vector256<T> vrotl<T>(Vector256<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vrotl(v8u(x), offset));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vrotl(v16u(x), offset));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vrotl(v32u(x), offset));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vrotl(v64u(x), offset));
            else
                throw unsupported<T>();
        }
    }
}