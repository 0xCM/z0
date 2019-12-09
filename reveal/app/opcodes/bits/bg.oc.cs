//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
 
    using static zfunc;
    using static As;

    /// <summary>
    /// Opcodes for bitgrid operations
    /// </summary>
    partial class bgoc
    {        
        public static BitGrid256<N16,N16,ushort> transpose(BitGrid256<N16,N16,ushort> g)                
            => BitGrid.transpose(g);

        public static bit read_bit_from_vector(in BitCells<N23,byte> src)
            => BitGrid.readbit(in src.Head, 3);

        public static int segments()
            => BitCells<N23,byte>.SegCount;

        public static int count_segs()
            => BitCalcs.cellcount<N20,N30,uint>();

        public static bit readbit_row_col_2(int n, ulong src, int row, int col)    
            => BitGrid.readbit(n, in src, row, col);

        public static bit readbit_g_position(in ulong src, int pos)    
            => BitGrid.readbit<ulong>(in src, pos);

    }

}