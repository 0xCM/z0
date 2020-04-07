//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Core;    

    partial struct BitSpan
    {
        /// <summary>
        /// Obliterates all bitspan content
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static ref readonly BitSpan clear(in BitSpan src)
        {
            src.bits.Clear();
            return ref src;
        }

        /// <summary>
        /// Obliterates bitspan content higher than a specified maximum
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public ref readonly BitSpan clear(in BitSpan src, int maxbits)
        {
            if(Length <= maxbits)
                return ref src;
            
            src.Bits.Slice(maxbits).Clear();
            
            return ref src;
        }

        /// <summary>
        /// Clears a contiguous sequence of bits between two indices
        /// </summary>
        /// <param name="src">The source bits</param>
        /// <param name="i0">The index of the first bit to clear</param>
        /// <param name="i1">The index of the last bit to clear</param>
        [MethodImpl(Inline)]
        public static ref readonly BitSpan clear(in BitSpan src, int i0, int i1)
        {
            src.bits.Slice(i0, i0 - i1 + 1).Clear();
            return ref src;
        }
    }
}