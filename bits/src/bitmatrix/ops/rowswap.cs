//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;

    partial class BitMatrix
    {        
        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 32
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public static void rowswap(in BitMatrix16 A, int i, int j)
            => A.Data.Swap(i,j);        

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 32
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public static void rowswap(in BitMatrix32 A, int i, int j)
            => A.Data.Swap(i,j);        

        /// <summary>
        /// Interchanges the i'th and j'th rows where  0 <= i,j < 32
        /// </summary>
        /// <param name="i">A row index</param>
        /// <param name="j">A row index</param>
        [MethodImpl(Inline)]
        public static void rowswap(in BitMatrix64 A, int i, int j)
            => A.Data.Swap(i,j);        
    }
}