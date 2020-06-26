//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static Konst; 
    using static Memories;

    partial class dvec
    {    
        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vreverse(Vector128<byte> src)
            => vshuf16x8(src, VData.vdecrements<byte>(n128));

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vreverse(Vector128<sbyte> src)
            => vshuf16x8(src, VData.vdecrements<sbyte>(n128));

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vreverse(Vector128<short> src)
            => vswaphl(vshuf4x16(src, Arrange4L.DCBA, Arrange4L.DCBA));

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vreverse(Vector128<ushort> src)
            => vswaphl(vshuf4x16(src, Arrange4L.DCBA, Arrange4L.DCBA));

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vreverse(Vector128<int> src)
            => vperm4x32(src, Perm4L.DCBA);

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vreverse(Vector128<uint> src)
            => vperm4x32(src, Perm4L.DCBA);

        [MethodImpl(Inline), Op]
        public static Vector128<long> vreverse(Vector128<long> src)
            => vswaphl(src);

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vreverse(Vector128<ulong> src)
            => vswaphl(src);

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vreverse(Vector256<byte> src)
            => vshuf32x8(src, VData.vdecrements<byte>(n256));

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vreverse(Vector256<sbyte> src)
            => V0d.vconcat(vreverse(V0d.vhi(src)), vreverse(V0d.vlo(src)));

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vreverse(Vector256<short> src)
            => V0d.vconcat(vreverse(V0d.vhi(src)), vreverse(V0d.vlo(src)));

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vreverse(Vector256<ushort> src)
            => V0d.vconcat(vreverse(V0d.vhi(src)), vreverse(V0d.vlo(src)));

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vreverse(Vector256<int> src)
            => vperm8x32(src,MRev256u32);

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vreverse(Vector256<uint> src)
            => vperm8x32(src,MRev256u32);

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vreverse(Vector256<long> src)
            => vperm4x64(src,Perm4L.DCBA); 

        /// <summary>
        /// Reverses the source vector components
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vreverse(Vector256<ulong> src)
            => vperm4x64(src,Perm4L.DCBA);

        static Vector256<uint> MRev256u32 
            => v32u(VData.vload(n256,MRev256u32Data));
            
            //=> vbuild.parts(n256, 7u, 6u, 5u, 4u, 3u, 2u, 1u, 0u);       

        static ReadOnlySpan<byte> MRev256u32Data => new byte[]
        {
            0x07, 0x00, 0x00, 0x00, 0x06, 0x00, 0x00, 0x00,
            0x05, 0x00, 0x00, 0x00, 0x04, 0x00, 0x00, 0x00,
            0x03, 0x00, 0x00, 0x00, 0x02, 0x00, 0x00, 0x00,
            0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
        };
    }
}