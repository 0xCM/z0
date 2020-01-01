//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;
 
    partial struct BitSpan
    {
        /// <summary>
        /// Materializes a bitspan segment as a scalar value
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="offset">The source index to begin extraction</param>
        /// <param name="count">The number of source bits that contribute to the extract</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static T slice<T>(in BitSpan src, int offset, int count)
            where T : unmanaged
        {
            Span<bit> buffer = stackalloc bit[bitsize<T>()];
            src.Bits.Slice(offset, count).CopyTo(buffer);
            return BitPack.pack<T>(buffer);
        }

        /// <summary>
        /// Materializes a bitspan segment as a scalar value
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="offset">The source index to begin extraction</param>
        /// <param name="count">The number of source bits that contribute to the extract</param>
        /// <typeparam name="T">The scalar type</typeparam>
        [MethodImpl(Inline)]
        public static T slice<T>(in BitSpan src, int offset, int count, Span<bit> buffer)
            where T : unmanaged
        {            
            PolyData.copy(src.Bits, offset, count, buffer);
            return BitPack.pack<T>(buffer);
        }

    }
}