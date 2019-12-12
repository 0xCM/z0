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
        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<sbyte> vinc(Vector128<sbyte> src)
            =>  vadd(src, vbuild.units<sbyte>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vinc(Vector128<byte> src)
            =>  vadd(src, vbuild.units<byte>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<short> vinc(Vector128<short> src)
            =>  vadd(src, vbuild.units<short>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vinc(Vector128<ushort> src)
            =>  vadd(src, vbuild.units<ushort>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<int> vinc(Vector128<int> src)
            =>  vadd(src, vbuild.units<int>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vinc(Vector128<uint> src)
            =>  vadd(src, vbuild.units<uint>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<long> vinc(Vector128<long> src)
            =>  vadd(src, vbuild.units<long>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vinc(Vector128<ulong> src)
            =>  vadd(src, vbuild.units<ulong>(n128));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<sbyte> vinc(Vector256<sbyte> src)
            =>  vadd(src, vbuild.units<sbyte>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vinc(Vector256<byte> src)
            =>  vadd(src, vbuild.units<byte>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<short> vinc(Vector256<short> src)
            =>  vadd(src, vbuild.units<short>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vinc(Vector256<ushort> src)
            =>  vadd(src, vbuild.units<ushort>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<int> vinc(Vector256<int> src)
            =>  vadd(src, vbuild.units<int>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vinc(Vector256<uint> src)
            =>  vadd(src, vbuild.units<uint>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<long> vinc(Vector256<long> src)
            =>  vadd(src, vbuild.units<long>(n256));

        /// <summary>
        /// Inrements each component by 1
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vinc(Vector256<ulong> src)
            =>  vadd(src, vbuild.units<ulong>(n256));

    }
}