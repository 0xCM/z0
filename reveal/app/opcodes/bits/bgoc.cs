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
        public static BitGrid64<N8,N8,ulong> bg_fw64_transpose_8x8x64(BitGrid64<N8,N8,ulong> g)
            => BitGrid.transpose(g);

        public static BitGrid64<N8,N8,ulong> bg_fw64_transpose_8x8x64_ur(BitGrid64<N8,N8,ulong> g)
        {
            ulong src = g;
            var dst = BitGrid.alloc<byte>(n64,n8,n8);
            var x = dinx.vmov(n128,src);
            dst[7] = (byte)dinx.vmovemask(v8u(x));
            x = dinx.vsll(x,1);
            dst[6] = (byte)dinx.vmovemask(v8u(x));
            x = dinx.vsll(x,1);
            dst[5] = (byte)dinx.vmovemask(v8u(x));
            x = dinx.vsll(x,1);
            dst[4] = (byte)dinx.vmovemask(v8u(x));
            x = dinx.vsll(x,1);
            dst[3] = (byte)dinx.vmovemask(v8u(x));
            x = dinx.vsll(x,1);
            dst[2] = (byte)dinx.vmovemask(v8u(x));
            x = dinx.vsll(x,1);
            dst[1] = (byte)dinx.vmovemask(v8u(x));
            x = dinx.vsll(x,1);
            dst[0] = (byte)dinx.vmovemask(v8u(x));

            return dst.As<ulong>();
        }

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