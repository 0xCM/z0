//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;

    using static System.Runtime.Intrinsics.X86.Bmi2;
    using static System.Runtime.Intrinsics.X86.Bmi2.X64;

    using static Konst;        
    using static z;

    partial class math
    {
        /// <summary>
        /// Computes the full 64-bit product between two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static unsafe void mul32x64(in Pair<uint> src, ref Pair<uint> dst)                 
            => dst.Right = MultiplyNoFlags(src.Left, src.Right, gptr(dst.Left));

        /// <summary>
        /// Computes the full 64-bit product between two unsigned 32-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static Pair<uint> mul32x64(in Pair<uint> src)
        {                         
            var dst = default(Pair<uint>);
            mul32x64(src, ref dst);
            return dst;
        }

        /// <summary>
        /// Computes the full 128-bit product between two unsigned 64-bit integers
        /// </summary>
        /// <param name="src">The source integers</param>
        /// <param name="dst">The multiplication result, partitioned into lo/hi parts</param>
        [MethodImpl(Inline), Op]
        public static Pair<ulong> mul64x128(in Pair<ulong> src)
        {                         
            var dst = default(Pair<ulong>);
            mul64x128(src, ref dst);
            return dst;
        }
    }
}