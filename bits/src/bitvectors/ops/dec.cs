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
        /// Arithmetically decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<T> dec<T>(BitVector<T> x)
            where T : unmanaged
                => gmath.dec(x.Data);

        /// <summary>
        /// Arithmetically decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        public static BitVector4 dec(BitVector4 x)
        {
            if(x.data > 0)
                return x.data--;
            else
                return  0xF;
        }

        /// <summary>
        /// Arithmetically decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector8 dec(BitVector8 x)        
            => math.dec(x.data);
        
        /// <summary>
        /// Arithmetically decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector16 dec(BitVector16 x)        
            => math.dec(x.data);

        /// <summary>
        /// Arithmetically decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector32 dec(BitVector32 x)        
            => math.dec(x.data);

        /// <summary>
        /// Arithmetically decrements the source vector
        /// </summary>
        /// <param name="x">The source vector</param>
        [MethodImpl(Inline)]
        public static BitVector64 dec(BitVector64 x)        
            => math.dec(x.data);
    }
}