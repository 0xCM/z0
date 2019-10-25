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
        /// Rotates each component the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<byte> vrotl(Vector128<byte> src, byte offset)
        {
            const byte bitsize = 8;
            return dinx.vor(
                dinx.vsll(src, offset),
                dinx.vsrl(src, (byte)(bitsize - offset))
                );             
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<ushort> vrotl(Vector128<ushort> src, byte offset)
        {
            const byte bitsize = 16;
            return dinx.vor(
                dinx.vsll(src, offset),
                dinx.vsrl(src, (byte)(bitsize - offset))
                );             
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vrotl(Vector128<uint> src, byte offset)
        {
            const byte bitsize = 32;
            var x = dinx.vsll(src, offset);
            var y = dinx.vsrl(src, (byte)(bitsize-offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotl(Vector128<ulong> src, byte offset)
        {
            const byte bitsize = 64;
            var x = dinx.vsll(src, offset);
            var y = dinx.vsrl(src, (byte)(bitsize-offset));   
            return dinx.vor(x,y);             
        }


        /// <summary>
        /// Rotates each component the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<byte> vrotl(Vector256<byte> src, byte offset)
        {
            const byte bitsize = 8;
            var x = dinx.vsll(src, offset);
            var y = dinx.vsrl(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<ushort> vrotl(Vector256<ushort> src, byte offset)
        {
            const byte bitsize = 16;
            var x = dinx.vsll(src, offset);
            var y = dinx.vsrl(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vrotl(Vector256<uint> src, byte offset)
        {
            const byte bitsize = 32;
            var x = dinx.vsll(src, offset);
            var y = dinx.vsrl(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vrotl(Vector256<ulong> src, byte offset)
        {
            const byte bitsize = 64;
            var x = dinx.vsll(src, offset);
            var y = dinx.vsrl(src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by the amount specified
        /// int the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<ulong> vrotl(Vector128<ulong> src, Vector128<ulong> offsets)
        {
            var x = dinx.vsllv(src,offsets);
            var y = dinx.vsrlv(src, dinx.vsub(Vector128u64,offsets));
            return dinx.vor(x,y);
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by the amount specified
        /// int the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector128<uint> vrotl(Vector128<uint> src, Vector128<uint> offsets)
        {
            var x = dinx.vsllv(src, offsets);
            var y = dinx.vsrlv(src, dinx.vsub(Vector128u32, offsets));
            return dinx.vor(x,y);
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by the 
        /// corresponding component the offsets vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<ulong> vrotl(Vector256<ulong> src, Vector256<ulong> offsets)
        {
            var x = dinx.vsllv(src,offsets);
            var y = dinx.vsrlv(src, dinx.vsub(Vector256u64,offsets));
            return dinx.vor(x,y);
        }

        /// <summary>
        /// Rotates each component the source vector leftwards by the 
        /// corresponding component the offsets vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vector256<uint> vrotl(Vector256<uint> src, Vector256<uint> offsets)
        {
            var x = dinx.vsllv(src,offsets);
            var y = dinx.vsrlv(src, dinx.vsub(Vector256u32,offsets));
            return dinx.vor(x,y);
        }


    }

}