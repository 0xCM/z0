//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;    
    
    partial class dinx
    {                
        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vrotr(in Vec128<byte> src, byte offset)
        {
            const byte bitsize = 8;
            var x = dinx.vsrl(in src, offset);
            var y = dinx.vsll(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vrotr(in Vec128<ushort> src, byte offset)
        {
            const byte bitsize = 16;
            var x = dinx.vsrl(in src, offset);
            var y = dinx.vsll(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vrotr(in Vec128<uint> src, byte offset)
        {
            const byte bitsize = 32;
            var x = dinx.vsrl(in src, offset);
            var y = dinx.vsll(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vrotr(in Vec128<ulong> src, byte offset)
        {
            const byte bitsize = 64;
            var x = dinx.vsrl(in src, offset);
            var y = dinx.vsll(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }


        /// <summary>
        /// Rotates each component in the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vrotr(in Vec256<byte> src, byte offset)
        {
            const byte bitsize = 8;
            var x = dinx.vsrl(in src, offset);
            var y = dinx.vsll(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vrotr(in Vec256<ushort> src, byte offset)
        {
            const byte bitsize = 16;
            var x = dinx.vsrl(in src, offset);
            var y = dinx.vsll(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vrotr(in Vec256<uint> src, byte offset)
        {
            const byte bitsize = 32;
            var x = dinx.vsrl(in src, offset);
            var y = dinx.vsll(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by a constant offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vrotr(in Vec256<ulong> src, byte offset)
        {
            const byte bitsize = 64;
            var x = dinx.vsrl(in src, offset);
            var y = dinx.vsll(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by the 
        /// corresponding component in the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> rotr(in Vec128<uint> src, Vec128<uint> offsets)
        {
            var x = dinx.srlv(in src, offsets);
            var y = dinx.vsllv(in src, dinx.vsub(Vec128u32, offsets));
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by the 
        /// corresponding component in the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> rotr(in Vec128<ulong> src, in Vec128<ulong> offsets)
        {
            var x = dinx.srlv(in src, offsets);
            var y = dinx.vsllv(in src, dinx.vsub(Vec128u64, offsets));
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by the 
        /// corresponding component in the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> rotr(in Vec256<uint> src, in Vec256<uint> offsets)
        {
            var x = dinx.srlv(in src, offsets);
            var y = dinx.vsllv(in src, dinx.vsub(Vec256u32, offsets));
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector rightwards by the 
        /// corresponding component in the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> rotr(in Vec256<ulong> src, in Vec256<ulong> offsets)
        {
            var x = dinx.srlv(in src, offsets);
            var y = dinx.vsllv(in src, dinx.vsub(Vec256u64, offsets));
            return dinx.vor(x,y);             
        }
    }

}