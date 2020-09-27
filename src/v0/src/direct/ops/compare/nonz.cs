//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static System.Runtime.Intrinsics.X86.Sse41;
    using static System.Runtime.Intrinsics.X86.Avx;

    using static Konst;

    partial struct V0d
    {
        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector128<byte> src)
            => ! TestZ(src,src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector128<sbyte> src)
            => ! TestZ(src, src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector128<short> src)
            => ! TestZ(src, src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector128<ushort> src)
            => ! TestZ(src, src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector128<int> src)
            => ! TestZ(src, src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector128<uint> src)
            => ! TestZ(src, src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector128<long> src)
            => ! TestZ(src, src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector128<ulong> src)
            => ! TestZ(src, src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector128<float> src)
            => ! TestZ(src, src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector128<double> src)
            => ! TestZ(src, src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector256<byte> src)
            => ! TestZ(src,src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector256<sbyte> src)
            => ! TestZ(src,src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector256<short> src)
            => ! TestZ(src,src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector256<ushort> src)
            => ! TestZ(src,src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector256<int> src)
            => ! TestZ(src,src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector256<uint> src)
            => ! TestZ(src,src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector256<long> src)
            => ! TestZ(src,src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector256<ulong> src)
            => ! TestZ(src,src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector256<float> src)
            => ! TestZ(src,src);

        /// <summary>
        /// Returns true if the source vector is nonzero, false otherwise
        /// </summary>
        /// <param name="src">The vector to test</param>
        [MethodImpl(Inline), Nonz]
        public static Bit32 vnonz(Vector256<double> src)
            => ! TestZ(src,src);
    }
}