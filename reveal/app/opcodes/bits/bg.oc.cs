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

        public static Vector256<byte> part63x3(ulong src)        
            => Bits.part63x3(src);

        public static void part63x3(ulong src, NatSpan<N21,byte> dst)            
            => Bits.part63x3(src, dst);

        public static void part63x3(ulong src, Span<byte> dst)            
            => Bits.part63x3(src, dst);

        public static Vector256<byte> bitgrid_vector256(BitGrid<byte> src, int block)        
            => BitGrid.vector(src, block,n256);
            
        public static BitGrid256<N16,N16,ushort> transpose(BitGrid256<N16,N16,ushort> g)                
            => BitGrid.transpose(g);

        public static bit read_bit_from_vector(in BitBlock<N23,byte> src)
            => BitGrid.readbit(in src.Head, 3);

        public static int segments()
            => BitBlock<N23,byte>.CellCount;

        public static int count_segs()
            => BitCalcs.tablecells<N20,N30,uint>();

        public static bit readbit_row_col_2(int n, ulong src, int row, int col)    
            => BitGrid.readbit(n, in src, row, col);

        public static bit readbit_g_position(in ulong src, int pos)    
            => BitGrid.readbit<ulong>(in src, pos);

    }

}