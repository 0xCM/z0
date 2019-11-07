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

        public static GridSpec calc_spec_1()
            => BitGrid.specify<N20,N30,uint>();

        public static GridSpec calc_spec_3()
            => BitGrid.specify(n20,n30,0u);

        public static GridSpec calc_spec_2()
            => BitGrid.specify<N20,N30,uint>();

        public static int count_segs()
            => BitGrid.segcount<N20,N30,uint>();


        public static bit bitread(in ulong src, int N, int row, int col)    
            => BitGrid.readbit(in src, N, row, col);

        public static void bitset(ref ulong src, int M, int N, int row, int col, bit state)    
            => BitGrid.setbit(ref src, M, N, row, col, state);

        public static bit bitread(in byte src, int N, int row, int col)    
            => BitGrid.readbit(in src, N, row, col);

        public static BitGrid<uint> bg_load_32x32x32(Span<uint> src)
            => BitGrid.load(src, 32,32);

        public static GridSpec bg_specify(int rows, int cols, int segwidth)
            => BitGrid.specify(rows,cols,segwidth);
    }

}