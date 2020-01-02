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
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vrotr<T>(Vector128<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vrotr(vcast8u(x), offset));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vrotr(vcast16u(x), offset));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vrotr(vcast32u(x), offset));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vrotr(vcast64u(x), offset));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vrotr<T>(Vector256<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vrotr(vcast8u(x), offset));
            if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vrotr(vcast16u(x), offset));
            if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vrotr(vcast32u(x), offset));
            if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vrotr(vcast64u(x), offset));
            else
                throw unsupported<T>();
        }     
    }
}