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

    partial class dinx
    {        
        [MethodImpl(NotInline)]
        static Vector128<T> vswapspec<T>(N128 n, params Swap[] swaps)
            where T : unmanaged  
        {
            var src = vbuild.increments<T>(n).ToSpan();
            var dst = src.Swap(swaps);
            return ginx.vload(n, in head(src));
        }

        [MethodImpl(Inline)]
        public static Vector128<byte> vswap(Vector128<byte> src, params Swap[] swaps)
            => vshuf16x8(src, vswapspec<byte>(n128, swaps));

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vswaphl(Vector128<sbyte> x)
            => vshuf2x64(x, Arrange2.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vswaphl(Vector128<byte> x)
            => vshuf2x64(x, Arrange2.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vswaphl(Vector128<short> x)
            => vshuf2x64(x, Arrange2.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vswaphl(Vector128<ushort> x)
            => vshuf2x64(x, Arrange2.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vswaphl(Vector128<int> x)
            => vshuf2x64(x, Arrange2.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vswaphl(Vector128<uint> x)
            => vshuf2x64(x, Arrange2.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vswaphl(Vector128<ulong> x)            
            => vshuf2x64(x, Arrange2.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vswaphl(Vector128<long> x)
            => vshuf2x64(x, Arrange2.BA);  

        /// <summary>
        /// Swaps the source vectors' hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vswaphl(Vector256<byte> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vswaphl(Vector256<sbyte> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vswaphl(Vector256<short> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vswaphl(Vector256<ushort> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vswaphl(Vector256<long> x)
            => vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vswaphl(Vector256<ulong> x)
            => vperm2x128(x,x, Perm2x4.DA);
    }
}