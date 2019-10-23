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

    partial class bitvector
    {
        /// <summary>
        /// Creates a generic bitvector of natural length from a single cell
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="n">The bitvector length</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static BitVector<N,T> from<N,T>(T src, N n = default)        
            where N : ITypeNat, new()
            where T : unmanaged
                => BitVector<N,T>.FromCell(src);


    }

}