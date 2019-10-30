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
        /// Rotates each component the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotr(Vector128<byte> src, byte offset)
        {
            const byte bitsize = 8;
            var x = dinx.vsrl(src, offset);
            var y = dinx.vsll(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vrotr(Vector128<ushort> src, byte offset)
        {
            const byte bitsize = 16;
            var x = dinx.vsrl(src, offset);
            var y = dinx.vsll(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vrotr(Vector128<uint> src, byte offset)
        {
            const byte bitsize = 32;
            var x = dinx.vsrl(src, offset);
            var y = dinx.vsll(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotr(Vector128<ulong> src, byte offset)
        {
            const byte bitsize = 64;
            var x = dinx.vsrl(src, offset);
            var y = dinx.vsll(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vrotr(Vector256<byte> src, byte offset)
        {
            const byte bitsize = 8;
            var x = dinx.vsrl(src, offset);
            var y = dinx.vsll(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vrotr(Vector256<ushort> src, byte offset)
        {
            const byte bitsize = 16;
            var x = dinx.vsrl(src, offset);
            var y = dinx.vsll(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vrotr(Vector256<uint> src, byte offset)
        {
            const byte bitsize = 32;
            var x = dinx.vsrl(src, offset);
            var y = dinx.vsll(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vrotr(Vector256<ulong> src, byte offset)
        {
            const byte bitsize = 64;
            var x = dinx.vsrl(src, offset);
            var y = dinx.vsll(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by the 
        /// corresponding component the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vrotr(Vector128<uint> src, Vector128<uint> offsets)
        {
            var x = dinx.vsrlv(src, offsets);
            var y = dinx.vsllv(src, dinx.vsub(Vector128u32, offsets));
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by the 
        /// corresponding component the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotr(Vector128<ulong> src, Vector128<ulong> offsets)
        {
            var x = dinx.vsrlv(src, offsets);
            var y = dinx.vsllv(src, dinx.vsub(Vector128u64, offsets));
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by the 
        /// corresponding component the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vrotr(Vector256<uint> src, Vector256<uint> offsets)
        {
            var x = dinx.vsrlv(src, offsets);
            var y = dinx.vsllv(src, dinx.vsub(Vector256u32, offsets));
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector rightwards by the 
        /// corresponding component the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vrotr(Vector256<ulong> src, Vector256<ulong> offsets)
        {
            var x = dinx.vsrlv(src, offsets);
            var y = dinx.vsllv(src, dinx.vsub(Vector256u64, offsets));
            return dinx.vor(x,y);             
        }
    }

}