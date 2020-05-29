//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;

    using static Seed;
    using static Vectors;
    using static Typed;

    [ApiHost]
    public readonly struct VCompactor : IApiHost<VCompactor>
    {
        /// <summary>
        /// 16x16i -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector256<short> src, W8 w, N0 z)            
            => v8u(dvec.vpackss(dvec.vlo(src), dvec.vhi(src)));

        /// <summary>
        /// 8x16u -> 8x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector128<ushort> x, W8 w)            
            => dvec.vcompact(x, default, w128, z8);

        /// <summary>
        /// 16x16u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector256<ushort> src, W8 w)            
            => dvec.vpackus(dvec.vlo(src), dvec.vhi(src));

        /// <summary>
        /// 8x32u -> 8x8u (a scalar vector)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(Vector256<uint> src, W8 w)            
            => dvec.vcompact(dvec.vcompact(src, n128,z16),w128,z8);

        /// <summary>
        /// 16x32u -> 16x8u
        /// </summary>
        /// <param name="src">The source vector tuple</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vcompact(in Vector512<uint> src, W8 w)            
            => dvec.vcompact(src.Lo, src.Hi, w128, z8);

        /// <summary>
        /// 16x16i -> 16x8i
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vcompact(Vector256<short> src, W8 w)            
            => dvec.vpackss(dvec.vlo(src), dvec.vhi(src));

        /// <summary>
        /// 8x32u -> 8x16u
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vcompact(Vector256<uint> src, W16 w)            
            => dvec.vcompact(dvec.vlo(src), dvec.vhi(src), w128, z16);

        /// <summary>
        /// 8x32i -> 8x16i
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target vector width</param>
        /// <param name="t">A target component type representative</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vcompact(Vector256<int> src, W16 w)            
            => dvec.vcompact(dvec.vlo(src), dvec.vhi(src),w128,z16i);

        /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vcompact(Vector256<ulong> src, W32 w)
            => Vectors.vparts(n128, (uint)vcell(src, 0),(uint)vcell(src, 1),(uint)vcell(src, 2),(uint)vcell(src, 3));

        /// <summary>
        /// 4x64w -> 4x32w
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vcompact(Vector256<long> src, W32 w)            
            => Vectors.vpartsi(n128, (int)vcell(src, 0), (int)vcell(src, 1), (int)vcell(src, 2), (int)vcell(src, 3));

        /// <summary>
        /// 8x16u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact(Vector128<ushort> src, W64 w)            
            => vcell64(dvec.vcompact(src, default, n128, z8),0);

        /// <summary>
        /// 8x32u -> 64u (a scalar)
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="w">The target width</param>
        /// <param name="t">A target type representative</param>
        [MethodImpl(Inline), Op]
        public static ulong vcompact(Vector256<uint> src, W64 w)            
            => dvec.vcompact(dvec.vcompact(src, n128,z16), w64, z64);
    }
}