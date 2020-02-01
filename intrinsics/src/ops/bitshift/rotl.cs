//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        /// Rotates each component the source vector leftwards by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static Vector128<byte> vrotl(Vector128<byte> src, [Shift] byte count)
            => dinx.vor(dinx.vsll(src, count),dinx.vsrl(src, (byte)(8 - count)));             
        
        /// <summary>
        /// Rotates each component the source vector leftwards by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ushort> vrotl(Vector128<ushort> src, [Shift] byte count)
            => dinx.vor(dinx.vsll(src, count), dinx.vsrl(src, (byte)(16 - count)));             

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static Vector128<uint> vrotl(Vector128<uint> src, [Shift] byte count)
            => dinx.vor(dinx.vsll(src, count), dinx.vsrl(src, (byte)(32-count)));

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static Vector128<ulong> vrotl(Vector128<ulong> src, [Shift] byte count)
            => dinx.vor(dinx.vsll(src, count),dinx.vsrl(src, (byte)(64 - count)));             

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static Vector256<byte> vrotl(Vector256<byte> src, [Shift] byte count)
            => dinx.vor(dinx.vsll(src, count),dinx.vsrl(src, (byte)(8 - count)));             

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ushort> vrotl(Vector256<ushort> src, [Shift] byte count)
            => dinx.vor(dinx.vsll(src, count),dinx.vsrl(src, (byte)(16 - count)));             

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static Vector256<uint> vrotl(Vector256<uint> src, [Shift] byte count)
            => dinx.vor(dinx.vsll(src, count),dinx.vsrl(src, (byte)(32 - count)));             

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified bitcount
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The magnitude of the rotation</param>
        [MethodImpl(Inline), Op]
        public static Vector256<ulong> vrotl(Vector256<ulong> src, [Shift] byte count)
            => dinx.vor(dinx.vsll(src, count),dinx.vsrl(src, (byte)(64 - count)));             



    }

}