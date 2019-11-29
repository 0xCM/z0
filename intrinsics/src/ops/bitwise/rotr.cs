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
        static Vector256<ulong> Vector256u64 
        {
            [MethodImpl(Inline)]
            get => dinx.vbroadcast(n256,64ul);
        }

        static Vector256<uint> Vector256u32 
        {
            [MethodImpl(Inline)]
            get => dinx.vbroadcast(n256,32u);
        }

        static Vector128<ulong> Vector128u64 
        {
            [MethodImpl(Inline)]
            get => dinx.vbroadcast(n128, 64ul);
        }

        static Vector128<uint> Vector128u32 
        {
            [MethodImpl(Inline)]
            get => dinx.vbroadcast(n128,32u);
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotr(Vector128<byte> src, int shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, 8 - shift));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vrotr(Vector128<ushort> src, int shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, 16 - shift));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vrotr(Vector128<uint> src, int shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, 32 - shift));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotr(Vector128<ulong> src, int shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, 64 - shift));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a specified shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vrotr(Vector256<byte> src, int shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, 8 - shift));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a specified shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vrotr(Vector256<ushort> src, int shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, 16 - shift));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vrotr(Vector256<uint> src, int shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, 32 - shift));             

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant shift
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vrotr(Vector256<ulong> src, int shift)
            => dinx.vor(dinx.vsrl(src, shift),dinx.vsll(src, 64 - shift));             

        /// <summary>
        /// Rotates each component the source vector rightwards by the 
        /// corresponding component the shift vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vrotr(Vector128<uint> src, Vector128<uint> shift)
            => dinx.vor(dinx.vsrlv(src, shift),dinx.vsllv(src, dinx.vsub(Vector128u32, shift)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by the 
        /// corresponding component the shift vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotr(Vector128<ulong> src, Vector128<ulong> shift)
            => dinx.vor(dinx.vsrlv(src, shift),dinx.vsllv(src, dinx.vsub(Vector128u64, shift)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by the 
        /// corresponding component the shift vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vrotr(Vector256<uint> src, Vector256<uint> shift)
            => dinx.vor(dinx.vsrlv(src, shift),dinx.vsllv(src, dinx.vsub(Vector256u32, shift)));             

        /// <summary>
        /// Rotates each component the source vector rightwards by the 
        /// corresponding component the shift vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="shift">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vrotr(Vector256<ulong> src, Vector256<ulong> shift)
            => dinx.vor(dinx.vsrlv(src, shift),dinx.vsllv(src, dinx.vsub(Vector256u64, shift)));             
    }

}