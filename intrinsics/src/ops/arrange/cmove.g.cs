//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static zfunc;    
    using static aux;

    partial class ginx
    {
        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask that controls which bytes are written</param>
        /// <param name="dst">The target memory reference</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static void vcmove<T>(Vector128<T> src, Vector128<byte> mask, ref byte dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vcmove_u(src,mask,ref dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vcmove_i(src,mask,ref dst);
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The mask that controls which bytes are written</param>
        /// <param name="dst">The target memory reference</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static void vcmove<T>(Vector256<T> src, Vector256<byte> mask, ref byte dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vcmove_u(src,mask,ref dst);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vcmove_i(src,mask,ref dst);
            else
                throw unsupported<T>();
        }
    }
}