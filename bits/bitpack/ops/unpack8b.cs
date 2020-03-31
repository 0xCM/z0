//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    partial class BitPack
    {
        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block64<byte> unpack8(byte packed, in Block64<byte> unpacked, int block = 0)
        {
            unpack8(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block128<byte> unpack8(ushort packed, in Block128<byte> unpacked, int block = 0)
        {
            unpack8(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block256<byte> unpack8(uint packed, in Block256<byte> unpacked, int block = 0)
        {                
            unpack8(packed, unpacked.Block(block));
            return ref unpacked;
        }

        /// <summary>
        /// Distributes each packed source bit to the least significant bit of the corresponding target byte
        /// </summary>
        /// <param name="packed">The packed source bits</param>
        /// <param name="unpacked">The blocked target</param>
        /// <param name="block">The block index</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static ref readonly Block512<byte> unpack8(ulong packed, in Block512<byte> unpacked, int block = 0)        
        {
            unpack8(packed, unpacked.Block(block));
            return ref unpacked;
        }
    }
}