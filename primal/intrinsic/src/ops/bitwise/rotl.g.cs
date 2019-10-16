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
        /// Rotates each component in the source vector leftwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<T> vrotl<T>(in Vec128<T> src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vrotl(in uint8(in src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotl(in uint16(in src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotl(in uint32(in src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotl(in uint64(in src), offset));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<T> vrotl<T>(in Vec256<T> src, byte offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vrotl(in uint8(in src), offset));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vrotl(in uint16(in src), offset));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vrotl(in uint32(in src), offset));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(dinx.vrotl(in uint64(in src), offset));
            else
                throw unsupported<T>();
        }

    }

}