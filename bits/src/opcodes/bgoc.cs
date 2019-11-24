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

        public static BitGrid64<uint> bg64_and_32(BitGrid64<uint> gx, BitGrid64<uint> gy)
            => BitGrid.and(gx,gy);

        public static BitGrid64<N16,N4,uint> bg64_and_32(BitGrid64<N16,N4,uint> gx, BitGrid64<N16,N4,uint> gy)
            => BitGrid.and<uint>(gx,gy);

        public static BitGrid128<uint> bg_and_128x32(BitGrid128<uint> gx, BitGrid128<uint> gy)
            => BitGrid.and(gx,gy);

        public static BitGrid128<N16,N4,uint> bg_and_16x4_128x32(BitGrid128<N16,N4,uint> gx, BitGrid128<N16,N4,uint> gy)
            => BitGrid.and<uint>(gx,gy);

        public static BitGrid256<N32,N8,uint> bg_and_16x4_128x32(BitGrid256<N32,N8,uint> gx, BitGrid256<N32,N8,uint> gy)
            => BitGrid.and<uint>(gx,gy);

        public static void set_bit(ref uint src, byte pos, bit state)
            => gbits.set(ref src, pos, state);

        public static void set_bit_on(ref uint src, byte pos)
            => gbits.set(ref src, pos, bit.On);

        public static void set_bit_off(ref uint src, byte pos)
            => gbits.set(ref src, pos, bit.Off);

        public static void store_bitstring(BitString src, in BitGrid<N8,N32,ulong> dst)
            => src.StoreTo(dst);

        [MethodImpl(Inline)]
        static BitGrid<M,N,T> StoreTo<M,N,T>(this BitString src, in BitGrid<M,N,T> dst, M m = default, N n = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {            
            var count = gmath.min(NatMath.mul(m,n), src.Length);
            for(var i=0; i<count; i++)
                dst[i] = src[i];
            return dst;            
        }

        public static bit read_bit_from_vector(in BitCells<N23,byte> src)
            => BitGrid.readbit(in src.Head, 3);

        public static bit read_bit_from_vector_2(in BitCells<N23,byte> src)
            => src[3];

        public static void set_bit_in_vector(in BitCells<N23,byte> src)
            => src[9] = bit.On;

        public static void set_bits_in_grid(BitGrid<N23,N11,byte> src)
        {
            src[3] = bit.On;
            src[5] = bit.On;
            src[18] = bit.On;
        }

        public static void set_bits_in_grid_2(BitGrid<N23,N11,byte> src, int i, int j)
        {
            src[i] = bit.On;
            src[j] = bit.On;
        }

        public static bit read_bit_from_grid(in BitGrid<N23,N5,byte> src)
            => src[3];

        public static int segments()
            => BitCells<N23,byte>.SegCount;

        public static int count_segs()
            => BitCalcs.segcount<N20,N30,uint>();

        public static bit readbit_row_col_2(int n, ulong src, int row, int col)    
            => BitGrid.readbit(n, in src, row, col);

        public static bit readbit_g_position(in ulong src, int pos)    
            => BitGrid.readbit<ulong>(in src, pos);

        public static BitGrid<uint> bg_load_32x32x32(Span<uint> src)
            => BitGrid.load(src, 32,32);


    }

}