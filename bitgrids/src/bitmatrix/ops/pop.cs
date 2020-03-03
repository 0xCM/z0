//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class BitMatrix
    {        
        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)]
        public static uint pop(in BitMatrix8 A)
            => Bits.pop((ulong)A);

        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public static uint pop(in BitMatrix16 A)
        {
            ref readonly var src = ref head(A.Data.AsUInt64());
            var count = 0u;
            count += Bits.pop(skip(in src, 0));
            count += Bits.pop(skip(in src, 1));
            count += Bits.pop(skip(in src, 2));
            count += Bits.pop(skip(in src, 3));
            return count;            
        }

        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public static uint pop(in BitMatrix32 A)
        {
            const uint bytes = BitMatrix32.N * 3;
            
            ref readonly var src = ref head(A.Data.AsUInt64());
            var count = 0u;
            return count;            
        }

        /// <summary>
        /// Counts the number of enabled bits in the matrix
        /// </summary>
        [MethodImpl(Inline)] 
        public static uint pop(in BitMatrix64 A)
        {
            const int N = 64;
            var count = 0u;
            ref var src = ref A.Head;
            for(var i=0; i < N; i++)
                count += Bits.pop(skip(in src, i));
            return count;
        }
    }
}