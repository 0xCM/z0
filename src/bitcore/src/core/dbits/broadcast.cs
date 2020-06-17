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
    
    using static System.Runtime.Intrinsics.X86.Avx;
    using static System.Runtime.Intrinsics.X86.Avx2;

    using static Konst;

    partial class Bits
    {
        /// <summary>
        /// Replicates a 16-bit source over a 32-bit target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Broadcast]
        public static uint broadcast(ushort src, N32 w)
            => vbroadcast(src).AsUInt32().GetElement(0);

        /// <summary>
        /// Replicates an 8-bit source over a 64-bit target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Broadcast]
        public static ulong broadcast(byte src, N64 w)
            => vbroadcast(src).AsUInt64().GetElement(0);

        /// <summary>
        /// Replicates a 16-bit source over a 64-bit target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Broadcast]
        public static ulong broadcast(ushort src, N64 w)
            => vbroadcast(src).AsUInt64().GetElement(0);

        /// <summary>
        /// Replicates a 32-bit source over a 64-bit target
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="w">The target width</param>
        [MethodImpl(Inline), Broadcast]
        public static ulong broadcast(uint src, N64 w)
            => vbroadcast(src).AsUInt64().GetElement(0);

        [MethodImpl(Inline), Broadcast]
        static unsafe Vector128<byte> vbroadcast(byte src)
            => BroadcastScalarToVector128(&src);

        [MethodImpl(Inline), Broadcast]
        static unsafe Vector128<ushort> vbroadcast(ushort src)
            => BroadcastScalarToVector128(&src);

        [MethodImpl(Inline), Broadcast]
        static unsafe Vector128<uint> vbroadcast(uint src)
            => BroadcastScalarToVector128(&src);
    }
}