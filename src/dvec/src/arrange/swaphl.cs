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
        
    using static Konst; 

    partial class dvec
    {        
        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vswaphl(Vector128<sbyte> x)
            => V0d.vshuf2x64(x, Arrange2L.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vswaphl(Vector128<byte> x)
            => V0d.vshuf2x64(x, Arrange2L.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vswaphl(Vector128<short> x)
            => V0d.vshuf2x64(x, Arrange2L.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vswaphl(Vector128<ushort> x)
            => V0d.vshuf2x64(x, Arrange2L.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vswaphl(Vector128<int> x)
            => V0d.vshuf2x64(x, Arrange2L.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vswaphl(Vector128<uint> x)
            => V0d.vshuf2x64(x, Arrange2L.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vswaphl(Vector128<ulong> x)            
            => V0d.vshuf2x64(x, Arrange2L.BA);  

        /// <summary>
        /// Swaps 64-bit hi/lo segments of the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vswaphl(Vector128<long> x)
            => V0d.vshuf2x64(x, Arrange2L.BA);  

        /// <summary>
        /// Swaps the source vectors' hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vswaphl(Vector256<byte> x)
            => V0d.vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vswaphl(Vector256<sbyte> x)
            => V0d.vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vswaphl(Vector256<short> x)
            => V0d.vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vswaphl(Vector256<ushort> x)
            => V0d.vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vswaphl(Vector256<int> x)
            => V0d.vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vswaphl(Vector256<uint> x)
            => V0d.vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vswaphl(Vector256<long> x)
            => V0d.vperm2x128(x,x, Perm2x4.DA);

        /// <summary>
        /// Swaps hi/lo 128-bit lanes
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vswaphl(Vector256<ulong> x)
            => V0d.vperm2x128(x,x, Perm2x4.DA);
    }
}