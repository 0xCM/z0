//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;
    using static As;
    using static AsIn;

    partial class bvoc
    {



        [MethodImpl(Inline)]
        public static uint testbit2(ref uint src, int row, int col)
            => seek(ref src, col);

        public static uint testbit2(uint[] src, int row, int col)
        {
            //ref var head = ref Unsafe.AsRef<uint>((Unsafe.AsPointer(ref src)));
            return testbit2(ref head(ref src), row, col);
        }

        public static unsafe uint testbit3(uint[] src, int row, int col)
        {
            ref var head = ref Unsafe.AsRef<uint>((Unsafe.AsPointer(ref src)));
            return testbit2(ref head, row, col);
        }

        public static uint testbit14(uint[] src, int row, int col)
        {
            //ref var head = ref Unsafe.AsRef<uint>((Unsafe.AsPointer(ref src)));
            return testbit2(ref first(src), row, col);
        }

        public static bit testbit(BitMatrix32 src, int row, int col)
            => src[row,col];

        public static bool bg_lookup_rc(in BitGrid<N8,N8,byte> src, GridMap map, int row, int col)
            => src.GetState(row, col);

        public static bit bg_lookup_pos(in BitGrid<N8,N8,byte> src, int pos)
            => src.GetState(pos);

        public static byte bg_get_head(in BitGrid<N8,N8,byte> src)
            => src.Head;

        public static ref readonly CellMap bg_cellmap_lookup_1(in BitGrid<N8,N8,byte> src, int row, int col)
            => ref src.CellMap(row,col);

        public static ref readonly CellMap bg_cellmap_lookup_2(in BitGrid<N8,N8,byte> src, int pos)
            => ref src.CellMap(pos);

        public static ref readonly CellMap cellmap_lookup_1(GridMap src, int row, int col)
            => ref src[row,col];

        public static ref readonly CellMap cellmap_lookup_2(GridMap src, int pos)
            => ref src[pos];

        public static ref uint bitcells_segment_32u(BitCells<uint> src, int pos)
            => ref src.Segment(pos);
            
        public static ReadOnlySpan<char> bitchars_32u(uint value)
            => gbits.bitchars(value);

        public static BitVector32 and_bv_32u(BitVector32 x, BitVector32 y)
            => BitVector.and(x,y);

        public static BitVector32 and_bv_o32u(BitVector32 x, BitVector32 y)
            => x & y;

    

        public static BitVector32 or_bv_32u(BitVector32 x, BitVector32 y)
            => BitVector.or(x,y);

        public static BitVector32 or_bv_o32u(BitVector32 x, BitVector32 y)
            => x | y;

        
        public static BitVector32 xor_bv_32u(BitVector32 x, BitVector32 y)
            => BitVector.xor(x,y);

        public static BitVector32 xor_bv_o32u(BitVector32 x, BitVector32 y)
            => x ^ y;

        public static BitVector32 sll_bv_32u(BitVector32 x, int offset)
            => BitVector.sll(x,offset);

        public static BitVector32 sll_bv_o32u(BitVector32 x, int offset)
            => x << offset;
        
        public static BitVector32 srl_bv_32u(BitVector32 x, int offset)
            => BitVector.srl(x,offset);

        public static BitVector32 srl_bv_o32u(BitVector32 x, int offset)
            => x >> offset;

        public static BitVector32 flip_bv_32u(BitVector32 x)
            => BitVector.not(x);

        public static BitVector32 flip_bv_o32u(BitVector32 x)
            => ~x;
        
        public static BitVector32 negate_bv_32u(BitVector32 x)
            => BitVector.negate(x);

        public static BitVector32 negate_bv_o32u(BitVector32 x)
            => -x;

        public static BitVector32 inc_bv_32u(BitVector32 x)
            => BitVector.inc(x);

        public static BitVector32 inc_bv_o32u(BitVector32 x)
            => ++x;

        public static BitVector32 dec_bv_32u(BitVector32 x)
            => BitVector.dec(x);

        public static BitVector32 dec_bv_o32u(BitVector32 x)
            => --x;

        public static BitVector32 rotl_bv_32u(BitVector32 x, int offset)
            => BitVector.rotl(x,offset);

        public static BitVector32 rotr_bv_32u(BitVector32 x, int offset)
            => BitVector.rotr(x, offset);
    }

}