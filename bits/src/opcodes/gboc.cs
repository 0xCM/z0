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
    public static class bgoc
    {        

        public static bit read_bit_from_vector(BitVector<N23,byte> src)
            => BitGrid.readbit(in src.Head, 3);

        public static bit read_bit_from_vector_2(BitVector<N23,byte> src)
            => src[3];

        public static void set_bit_in_vector(BitVector<N23,byte> src)
            => src[3] = bit.On;

        public static void set_bit_in_grid(BitGrid<N23,N1,byte> src)
            => src[3] = bit.On;

        public static int segments()
            => BitVector<N23,byte>.SegCount;


        public static GridSpec calc_spec_1()
            => BitGrid.specify<N20,N30,uint>();

        public static GridSpec calc_spec_3()
            => BitGrid.specify(n20,n30,0u);

        public static GridSpec calc_spec_2()
            => BitGrid.specify<N20,N30,uint>();

        public static int count_segs()
            => BitGrid.segments<N20,N30,uint>();

        public static bit readbit_row_col_many(in GridMoniker moniker, in ulong src)    
        {
            var x = BitGrid.readbit(moniker, in src, 1, 2);
            x &= BitGrid.readbit(moniker, in src, 1, 3);
            x &= BitGrid.readbit(moniker, in src, 4, 5);
            return x;
        }

        public static bit readbit_row_col(in GridMoniker moniker, in ulong src, int row, int col)    
            => BitGrid.readbit(moniker, in src, row, col);

        public static bit readbit_row_col_2(int n, ulong src, int row, int col)    
            => BitGrid.readbit(n, in src, row, col);

        public static bit readbit_g_position(in ulong src, int pos)    
            => BitGrid.readbit<ulong>(in src, pos);


        public static void setbit(in GridMoniker moniker, int row, int col, bit state, ref ulong dst)    
            => BitGrid.setbit(moniker, row, col, state, ref dst);


        public static BitGrid<uint> bg_load_32x32x32(Span<uint> src)
            => BitGrid.load(src, 32,32);


        public static GridSpec bg_specify(ushort rows, ushort cols, ushort segwidth)
            => BitGrid.specify(rows,cols,segwidth);
    }

}