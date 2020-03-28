//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static vgeneric;

    partial class gvec
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
        public static void vmaskstore8<T>(Vector128<T> src, Vector128<byte> mask, in Block128<byte> dst)
            where T : unmanaged
                => dvec.vmaskstore(v8u(src),mask, dst);

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
        public static void vmaskstore8<T>(Vector256<T> src, Vector256<byte> mask, in Block256<byte> dst)
            where T : unmanaged
                => dvec.vmaskstore(v8u(src),mask, dst);

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
        public static void vmaskstore32<T>(Vector128<T> src, Vector128<uint> mask, in Block128<uint> dst)
            where T : unmanaged
                => dvec.vmaskstore(v32u(src),mask,dst);

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
        public static void vmaskstore32<T>(Vector256<T> src, Vector256<uint> mask, in Block256<uint> dst)
            where T : unmanaged
                => dvec.vmaskstore(v32u(src),mask, dst);

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
        public static void vmaskstore64<T>(Vector128<T> src, Vector128<ulong> mask, in Block128<ulong> dst)
            where T : unmanaged
                => dvec.vmaskstore(v64u(src),mask,dst);

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
        public static void vmaskstore64<T>(Vector256<T> src, Vector256<ulong> mask, in Block256<ulong> dst)
            where T : unmanaged
                => dvec.vmaskstore(v64u(src),mask, dst);
    }
}