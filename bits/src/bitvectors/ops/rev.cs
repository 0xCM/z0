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
        public static BitVector8 rev(BitVector8 x)        
            => Bits.rev(x.data);
        
        /// <summary>
        /// Decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 rev(BitVector16 x)        
            => Bits.rev(x.data);

        /// <summary>
        /// Decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 rev(BitVector32 x)        
            => Bits.rev(x.data);

        /// <summary>
        /// Decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 rev(BitVector64 x)        
            => Bits.rev(x.data);
    }
}