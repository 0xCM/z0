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
    using static System.Runtime.Intrinsics.X86.Popcnt;
    using static System.Runtime.Intrinsics.X86.Popcnt.X64;
 
    using static zfunc;
    
    partial class Bits
    {                
        [MethodImpl(Inline)]
        public static unsafe int popbs(ulong src)
        {
            Span<byte> bytes = new Span<byte>(&src,8);
            ref readonly var data = ref head(bytes);
            var count = 0;
            var index = 0;
            count += BitStore.PopCount(skip(in data, index++));
            count += BitStore.PopCount(skip(in data, index++));
            count += BitStore.PopCount(skip(in data, index++));
            count += BitStore.PopCount(skip(in data, index++));
            count += BitStore.PopCount(skip(in data, index++));
            count += BitStore.PopCount(skip(in data, index++));
            count += BitStore.PopCount(skip(in data, index++));
            count += BitStore.PopCount(skip(in data, index++));
            return count;
        }

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(sbyte src)
            => PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(byte src)
            => PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(short src)
            => PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(ushort src)
            => PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(int src)
            => PopCount((uint)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(uint src)
            => PopCount(src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(long src)
            => (uint)PopCount((ulong)src);

        /// <summary>
        /// Counts the enabled bits in the source
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static uint pop(ulong src)
            => (uint)PopCount(src);

        [MethodImpl(Inline)]
        public static uint pop(ulong x0, ulong x1)
            => (uint)(PopCount(x0) + PopCount(x1));

        [MethodImpl(Inline)]
        public static uint pop(ulong x0, ulong x1, ulong x2, ulong x3)
            => (uint)(PopCount(x0) + PopCount(x1) + PopCount(x2) + PopCount(x3));

        [MethodImpl(Inline)]
        public static uint pop(ulong x0, ulong x1, ulong x2, ulong x3, ulong x4, ulong x5, ulong x6, ulong x7)
            => pop(x0,x1,x2,x3) + pop(x4,x5,x6,x7);

    }
}