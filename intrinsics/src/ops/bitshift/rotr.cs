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
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotr(Vector128<byte> src, byte shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, (byte)(8 - shift)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vrotr(Vector128<ushort> src, byte shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, (byte)(16 - shift)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vrotr(Vector128<uint> src, byte shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, (byte)(32 - shift)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotr(Vector128<ulong> src, byte shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, (byte)(64 - shift)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a specified shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vrotr(Vector256<byte> src, byte shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, (byte)(8 - shift)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a specified shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vrotr(Vector256<ushort> src, byte shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, (byte)(16 - shift)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vrotr(Vector256<uint> src, byte shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, (byte)(32 - shift)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vrotr(Vector256<ulong> src, byte shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, (byte)(64 - shift)));             

        static Vector256<ulong> Vector256u64 
        {
            [MethodImpl(Inline)]
            get => CpuVector.vbroadcast(n256,64ul);
        }

        static Vector256<uint> Vector256u32 
        {
            [MethodImpl(Inline)]
            get => CpuVector.vbroadcast(n256,32u);
        }

        static Vector128<ulong> Vector128u64 
        {
            [MethodImpl(Inline)]
            get => CpuVector.vbroadcast(n128, 64ul);
        }

        static Vector128<uint> Vector128u32 
        {
            [MethodImpl(Inline)]
            get => CpuVector.vbroadcast(n128,32u);
        }


    }

}