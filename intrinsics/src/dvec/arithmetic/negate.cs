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

    using static Core;    

    partial class dvec    
    {
        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<sbyte> vnegate(Vector128<sbyte> src)
            =>  vsub(default, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vnegate(Vector128<byte> src)
            =>  vsub(vnot(src), gvec.vones<byte>(n128));

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<short> vnegate(Vector128<short> src)
            =>  vsub(default, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vnegate(Vector128<ushort> src)
            =>  vsub(vnot(src), gvec.vones<ushort>(n128));

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<int> vnegate(Vector128<int> src)
            =>  vsub(default, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vnegate(Vector128<uint> src)
            =>  vsub(vnot(src), gvec.vones<uint>(n128));

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<long> vnegate(Vector128<long> src)
            =>  vsub(default, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vnegate(Vector128<ulong> src)
            =>  vsub(vnot(src), gvec.vones<ulong>(n128));

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<sbyte> vnegate(Vector256<sbyte> src)
            =>  vsub(default, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vnegate(Vector256<byte> src)
            =>  vsub(vnot(src), gvec.vones<byte>(n256));

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<short> vnegate(Vector256<short> src)
            =>  vsub(default, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vnegate(Vector256<ushort> src)
            =>  vsub(vnot(src), gvec.vones<ushort>(n256));

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<int> vnegate(Vector256<int> src)
            =>  vsub(default, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vnegate(Vector256<uint> src)
            =>  vsub(vnot(src), gvec.vones<uint>(n256));

        /// <summary>
        /// Negates the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<long> vnegate(Vector256<long> src)
            =>  vsub(default, src);

        /// <summary>
        /// Negates the source vector (Two's complement)
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vnegate(Vector256<ulong> src)
            =>  vsub(vnot(src), gvec.vones<ulong>(n256));


    }
}