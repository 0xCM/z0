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
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<byte> vrotl(in Vec128<byte> src, byte offset)
        {
            const byte bitsize = 8;
            return dinx.vor(
                dinx.vsll(in src, offset),
                dinx.vsrl(in src, (byte)(bitsize - offset))
                );             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ushort> vrotl(in Vec128<ushort> src, byte offset)
        {
            const byte bitsize = 16;
            return dinx.vor(
                dinx.vsll(in src, offset),
                dinx.vsrl(in src, (byte)(bitsize - offset))
                );             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vrotl(in Vec128<uint> src, byte offset)
        {
            const byte bitsize = 32;
            var x = dinx.vsll(in src, offset);
            var y = dinx.vsrl(in src, (byte)(bitsize-offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vrotl(in Vec128<ulong> src, byte offset)
        {
            const byte bitsize = 64;
            var x = dinx.vsll(in src, offset);
            var y = dinx.vsrl(in src, (byte)(bitsize-offset));   
            return dinx.vor(x,y);             
        }


        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<byte> vrotl(in Vec256<byte> src, byte offset)
        {
            const byte bitsize = 8;
            var x = dinx.vsll(in src, offset);
            var y = dinx.vsrl(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ushort> vrotl(in Vec256<ushort> src, byte offset)
        {
            const byte bitsize = 16;
            var x = dinx.vsll(in src, offset);
            var y = dinx.vsrl(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vrotl(in Vec256<uint> src, byte offset)
        {
            const byte bitsize = 32;
            var x = dinx.vsll(in src, offset);
            var y = dinx.vsrl(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by a specified offset
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The magnitude of the rotation</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vrotl(in Vec256<ulong> src, byte offset)
        {
            const byte bitsize = 64;
            var x = dinx.vsll(in src, offset);
            var y = dinx.vsrl(in src, (byte)(bitsize - offset));   
            return dinx.vor(x,y);             
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by the amount specified
        /// int the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<ulong> vrotl(in Vec128<ulong> src, in Vec128<ulong> offsets)
        {
            var x = dinx.vsllv(src,offsets);
            var y = dinx.vsrlv(src, dinx.vsub(Vec128u64,offsets));
            return dinx.vor(x,y);
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by the amount specified
        /// int the corresponding offset vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec128<uint> vrotl(in Vec128<uint> src, in Vec128<uint> offsets)
        {
            var x = dinx.vsllv(src, offsets);
            var y = dinx.vsrlv(src, dinx.vsub(Vec128u32, offsets));
            return dinx.vor(x,y);
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by the 
        /// corresponding component in the offsets vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<ulong> vrotl(in Vec256<ulong> src, in Vec256<ulong> offsets)
        {
            var x = dinx.vsllv(src,offsets);
            var y = dinx.vsrlv(src, dinx.vsub(Vec256u64,offsets));
            return dinx.vor(x,y);
        }

        /// <summary>
        /// Rotates each component in the source vector leftwards by the 
        /// corresponding component in the offsets vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offsets">The offset vector</param>
        [MethodImpl(Inline)]
        public static Vec256<uint> vrotl(in Vec256<uint> src, in Vec256<uint> offsets)
        {
            var x = dinx.vsllv(src,offsets);
            var y = dinx.vsrlv(src, dinx.vsub(Vec256u32,offsets));
            return dinx.vor(x,y);
        }

        static readonly Vec128<uint> Vec128u32 = Vec128.Fill(32u);

        static readonly Vec128<ulong> Vec128u64 = Vec128.Fill(64ul);

        static readonly Vec256<uint> Vec256u32 = Vec256.Fill(32u);

        static readonly Vec256<ulong> Vec256u64 = Vec256.Fill(64ul);

    }

}