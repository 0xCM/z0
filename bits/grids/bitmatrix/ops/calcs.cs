//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;    

    partial class BitMatrix
    {        
        /// <summary>
        /// Computes the minimum number of cells required to store a bitmatrix where each row is data-type aligned
        /// </summary>
        /// <param name="w">The cell width</param>
        /// <param name="n">The number of matrix columns</param>
        /// <param name="m">The number of matrix rows</param>
        [MethodImpl(Inline)]
        public static int totalcells(int w, int m, int n)
            => BitCalcs.mincells(w,n) * m;
    }
}