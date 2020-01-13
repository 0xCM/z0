//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.OpCodes
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
 
    using static zfunc;
    using static As;

    /// <summary>
    /// Opcodes for bitmatrix operations
    /// </summary>
    [OpCodeProvider]
    public static class bitmatrix
    {        
        public static int cell_count_32x64x8()
            =>  BitMatrix.totalcells(n32,n64, z8);

        public static TableIndex tableindex_32x64x8(int row, int col)
            => BitMatrix.tableindex(row,col,n32,n64,z8);


    }

}