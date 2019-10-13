//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Collections.Generic;

    using static zfunc;    
    using static nfunc;
    using static As;

    partial class bitvector
    {
        /// <summary>
        /// Decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 inc(BitVector8 x)        
            => math.inc(x.data);
        
        /// <summary>
        /// Decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 inc(BitVector16 x)        
            => math.inc(x.data);

        /// <summary>
        /// Decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 inc(BitVector32 x)        
            => math.inc(x.data);

        /// <summary>
        /// Decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 inc(BitVector64 x)        
            => math.inc(x.data);
    }
}