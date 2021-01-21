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

    partial struct cpu
    {

    }

    partial struct z
    {
        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vshi(Vector128<sbyte> src)
            => v8i(cpu.vscalar(w128, vcell(v64u(src),1)));

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vshi(Vector128<byte> src)
            => v8u(cpu.vscalar(w128, vcell(v64u(src), 1)));

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vshi(Vector128<short> src)
            => gcpu.v16i(cpu.vscalar(w128, vcell(v64u(src), 1)));

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vshi(Vector128<ushort> src)
            => gcpu.v16u(cpu.vscalar(w128, vcell(v64u(src), 1)));

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vshi(Vector128<int> src)
            => v32i(cpu.vscalar(w128, vcell(v64u(src), 1)));

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vshi(Vector128<uint> src)
            => v32u(cpu.vscalar(w128, vcell(v64u(src), 1)));

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vshi(Vector128<long> src)
            => cpu.vscalar(w128, vcell(src,1));

        /// <summary>
        /// Creates a scalar vector from the upper 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vshi(Vector128<ulong> src)
            => cpu.vscalar(w128, vcell(src,1));
    }
}