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
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vrotl<T>(Vector128<T> src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vrotl(uint8(src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotl(uint16(src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotl(uint32(src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotl(uint64(src), offset));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vrotl<T>(Vector256<T> src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vrotl(uint8(src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotl(uint16(src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotl(uint32(src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotl(uint64(src), offset));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vrotr<T>(Vector128<T> src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vrotr(uint8(src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotr(uint16(src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotr(uint32(src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotr(uint64(src), offset));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vrotr<T>(Vector256<T> src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vrotr(uint8(src), offset));
            if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotr(uint16(src), offset));
            if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotr(uint32(src), offset));
            if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotr(uint64(src), offset));
            else
                throw unsupported<T>();
        }
    
        [MethodImpl(Inline)]
        public static Vector128<T> vrotl<T>(N128 n, in T a, byte offset)
            where T : unmanaged
        {                    
            vload(a, out Vector128<T> vA);
            return vrotl(vA,offset);
        }

        [MethodImpl(Inline)]
        public static void vrotl<T>(N128 n, in T a, byte offset, ref T z)
            where T : unmanaged
                => vstore(vrotl(n, in a, offset), ref z);


        [MethodImpl(Inline)]
        public static Vector256<T> vrotl<T>(N256 n, in T pX, byte offset)
            where T : unmanaged
        {                    
            vload(pX, out Vector256<T> vA);
            return vrotl(vA,offset);
        }

        [MethodImpl(Inline)]
        public static void vrotl<T>(N256 n, in T a, byte offset, ref T z)
            where T : unmanaged
                => vstore(vrotl(n,in a, offset), ref z);

     
    }

}