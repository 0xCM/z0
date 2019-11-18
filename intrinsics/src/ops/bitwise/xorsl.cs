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
        /// Computes x^(x << offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vxorsl(Vector128<byte> x, byte offset)
            => dinx.vxor(x, vsll(x,offset));

        /// <summary>
        /// Computes x^(x << offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vxorsl(Vector128<ushort> x, byte offset)
            => dinx.vxor(x, vsll(x,offset));

        /// <summary>
        /// Computes x^(x << offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vxorsl(Vector128<uint> x, byte offset)
            => dinx.vxor(x, vsll(x,offset));

        /// <summary>
        /// Computes x^(x << offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vxorsl(Vector128<ulong> x, byte offset)
            => dinx.vxor(x, vsll(x,offset));

        /// <summary>
        /// Computes x^(x << offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vxorsl(Vector256<byte> x, byte offset)
            => dinx.vxor(x, vsll(x,offset));

        /// <summary>
        /// Computes x^(x << offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vxorsl(Vector256<ushort> x, byte offset)
            => dinx.vxor(x, vsll(x,offset));

        /// <summary>
        /// Computes x^(x << offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vxorsl(Vector256<uint> x, byte offset)
            => dinx.vxor(x, vsll(x,offset));

        /// <summary>
        /// Computes x^(x << offset)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vxorsl(Vector256<ulong> x, byte offset)
            => dinx.vxor(x, vsll(x,offset));

        /// <summary>
        /// Computes x^(x << offsets)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vxorslv(Vector128<uint> x, Vector128<uint> offsets)
            => dinx.vxor(x, dinx.vsllv(x,offsets));

        /// <summary>
        /// Computes x^(x << offsets)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vxorslv(Vector128<ulong> x, Vector128<ulong> offsets)
            => dinx.vxor(x,dinx.vsllv(x,offsets));

        /// <summary>
        /// Computes x^(x << offsets)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vxorslv(Vector256<uint> x, Vector256<uint> offsets)
            => dinx.vxor(x, dinx.vsllv(x,offsets));

        /// <summary>
        /// Computes x^(x << offsets)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="offset">Specifies the shift offset for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vxorslv(Vector256<ulong> x, Vector256<ulong> offsets)
            => dinx.vxor(x, dinx.vsllv(x,offsets));
    }
}