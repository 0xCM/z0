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
    
    using static Root;    
    using static gvec;
    
    partial class ginx
    {
       /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector128<T> vrotr<T>(Vector128<T> x, [Shift] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vrotr(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotr(v16u(x), count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotr(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotr(v64u(x), count));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.UnsignedInts)]
        public static Vector256<T> vrotr<T>(Vector256<T> x, [Shift] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vrotr(v8u(x), count));
            if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotr(v16u(x), count));
            if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotr(v32u(x), count));
            if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotr(v64u(x), count));
            else
                throw unsupported<T>();
        }     
    }
}