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
        /// Computes x^(x << shift)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vxorsl(Vector128<byte> x, int shift)
            => dinx.vxor(x, vsll(x,shift));

        /// <summary>
        /// Computes x^(x << shift)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vxorsl(Vector128<ushort> x, int shift)
            => dinx.vxor(x, vsll(x,shift));

        /// <summary>
        /// Computes x^(x << shift)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vxorsl(Vector128<uint> x, int shift)
            => dinx.vxor(x, vsll(x,shift));

        /// <summary>
        /// Computes x^(x << shift)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vxorsl(Vector128<ulong> x, int shift)
            => dinx.vxor(x, vsll(x,shift));

        /// <summary>
        /// Computes x^(x << shift)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vxorsl(Vector256<byte> x, int shift)
            => dinx.vxor(x, vsll(x,shift));

        /// <summary>
        /// Computes x^(x << shift)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vxorsl(Vector256<ushort> x, int shift)
            => dinx.vxor(x, vsll(x,shift));

        /// <summary>
        /// Computes x^(x << shift)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vxorsl(Vector256<uint> x, int shift)
            => dinx.vxor(x, vsll(x,shift));

        /// <summary>
        /// Computes x^(x << shift)
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vxorsl(Vector256<ulong> x, int shift)
            => dinx.vxor(x, vsll(x,shift));

        /// <summary>
        /// Computes x[i]^(x[i] << shift[i])
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vxorslv(Vector128<uint> x, Vector128<uint> shift)
            => dinx.vxor(x, dinx.vsllv(x,shift));

        /// <summary>
        /// Computes x[i]^(x[i] << shift[i])
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vxorslv(Vector128<ulong> x, Vector128<ulong> shift)
            => dinx.vxor(x,dinx.vsllv(x,shift));

        /// <summary>
        /// Computes x[i]^(x[i] << shift[i])
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vxorslv(Vector256<uint> x, Vector256<uint> shift)
            => dinx.vxor(x, dinx.vsllv(x,shift));

        /// <summary>
        /// Computes x[i]^(x[i] << shift[i])
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="shift">Specifies the shift shift for each corresponding component</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vxorslv(Vector256<ulong> x, Vector256<ulong> shift)
            => dinx.vxor(x, dinx.vsllv(x,shift));
    }
}