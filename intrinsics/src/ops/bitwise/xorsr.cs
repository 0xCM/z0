//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static zfunc;    

    partial class dinx
    {
        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vxorsr(Vector128<byte> x, byte offset)
            => dinx.vxor(x, vsrl(x,offset));

        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vxorsr(Vector128<ushort> x, byte offset)
            => dinx.vxor(x, vsrl(x,offset));

        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vxorsr(Vector128<uint> x, byte offset)
            => dinx.vxor(x,vsrl(x,offset));

        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vxorsr(Vector128<ulong> x, byte offset)
            => dinx.vxor(x, vsrl(x,offset));

        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vxorsr(Vector256<byte> x, byte offset)
            => dinx.vxor(x, vsrl(x,offset));

        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vxorsr(Vector256<ushort> x, byte offset)
            => dinx.vxor(x, vsrl(x,offset));

        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vxorsr(Vector256<uint> x, byte offset)
            => dinx.vxor(x, vsrl(x,offset));

        /// <summary>
        /// Computes x^(x >> offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">The amount by which to shift each component</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vxorsr(Vector256<ulong> x, byte offset)
            => dinx.vxor(x, vsrl(x,offset));

        /// <summary>
        /// Computes x^(x >> offsets)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vxorsrv(Vector128<uint> x, Vector128<uint> offsets)
            => dinx.vxor(x, dinx.vsrlv(x,offsets));

        /// <summary>
        /// Computes x^(x >> offsets)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vxorsrv(Vector128<ulong> x, Vector128<ulong> offsets)
            => dinx.vxor(x, dinx.vsrlv(x, offsets));

        /// <summary>
        /// Computes x^(x >> offsets)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vxorsrv(Vector256<uint> x, Vector256<uint> offsets)
            => dinx.vxor(x, dinx.vsrlv(x, offsets));

        /// <summary>
        /// Computes x^(x >> offsets)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vxorsrv(Vector256<ulong> x, Vector256<ulong> offsets)
            => dinx.vxor(x, dinx.vsrlv(x, offsets));
    }
}