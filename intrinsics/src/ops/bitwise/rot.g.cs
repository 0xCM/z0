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
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Rotates each component the source vector leftwards by a constant offset
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vrotl<T>(Vector128<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vrotl(uint8(x), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotl(uint16(x), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotl(uint32(x), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotl(uint64(x), offset));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by a constant offset
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vrotl<T>(Vector256<T> x, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vrotl(uint8(x), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotl(uint16(x), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotl(uint32(x), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotl(uint64(x), offset));
            else
                throw unsupported<T>();
        }

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
                return generic<T>(dinx.vrotr(uint8(x), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotr(uint16(x), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotr(uint32(x), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotr(uint64(x), offset));
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
                return generic<T>(dinx.vrotr(uint8(x), offset));
            if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotr(uint16(x), offset));
            if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotr(uint32(x), offset));
            if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotr(uint64(x), offset));
            else
                throw unsupported<T>();
        }     
    }
}