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

    partial class ginx
    {
        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static void vmstore<T>(Vector128<T> src, Vector128<byte> mask, ref byte dst)
            where T : unmanaged
                => dinx.vmstore(v8u(src),mask,ref dst);

        /// <summary>
        /// Conditionally stores 32-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 32-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static void vmstore<T>(Vector128<T> src, Vector128<uint> mask, ref uint dst)
            where T : unmanaged
                => dinx.vmstore(v32u(src),mask,ref dst);

        /// <summary>
        /// Conditionally stores 8-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 8-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static void vmstore<T>(Vector256<T> src, Vector256<byte> mask, ref byte dst)
            where T : unmanaged
                => dinx.vmstore(v8u(src),mask,ref dst);

        /// <summary>
        /// Conditionally stores 32-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 32-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static void vmstore<T>(Vector256<T> src, Vector256<uint> mask, ref uint dst)
            where T : unmanaged
                => dinx.vmstore(v32u(src),mask,ref dst);

        /// <summary>
        /// Conditionally stores 64-bit segments from the source vector to memory according to a vectorized mask
        /// where the hi bit of each corresponding 64-bit segment determines whether the source data is written
        /// If the hi bit is enabled, content is written, otherwise it is not
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="mask">The source content selector</param>
        /// <param name="dst">The target memory</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static void vmstore<T>(Vector256<T> src, Vector256<ulong> mask, ref ulong dst)
            where T : unmanaged
                => dinx.vmstore(v64u(src),mask,ref dst);
    }
}