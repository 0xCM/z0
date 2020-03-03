//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;

    partial class ExtendedBlocks    
    {
        /// <summary>
        /// Fills a caller-supplied buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block64<byte> GetBytes(ulong src, in Block64<byte> dst)
        {         
            Bytes.to(in src, dst);
            return ref dst;
        }

        /// <summary>
        /// Fills a caller-supplied buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block32<byte> GetBytes(uint src, in Block32<byte> dst)
        {         
            Bytes.to(in src, dst);
            return ref dst;
        }

        /// <summary>
        /// Fills a caller-supplied buffer with source bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target buffer</param>
        [MethodImpl(Inline), Op]
        public static ref readonly Block16<byte> GetBytes(ushort src, in Block16<byte> dst)
        {
            Bytes.to(in src, dst);
            return ref dst;
        }
    }
}