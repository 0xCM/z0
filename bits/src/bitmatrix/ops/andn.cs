//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static ref BitMatrix16 andn(ref BitMatrix16 A, in BitMatrix16 B)
        {
            A.GetCells(out Vec256<ushort> vLhs);
            B.GetCells(out Vec256<ushort> vRhs);
            dinx.vandn(vLhs,vRhs).StoreTo(ref A[0]);
            return ref A;
        }

        [MethodImpl(Inline)]
        public static BitMatrix16 andn(BitMatrix16 A, BitMatrix16 B)
        {
            var C = A.Replicate();
            return andn(ref C, B);
        }

        public static ref BitMatrix32 andn(ref BitMatrix32 A, in BitMatrix32 B)
        {
            const int rowstep = 8;
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                A.GetCells(i, out Vec256<uint> x);
                B.GetCells(i, out Vec256<uint> y);
                dinx.vandn(x,y).StoreTo(ref A[i]);
            }
            return ref A;
        }

        [MethodImpl(Inline)]
        public static BitMatrix32 andn(BitMatrix32 A, BitMatrix32 B)
        {
            var C = A.Replicate();
            return andn(ref C, B);
        }

        public static ref BitMatrix64 andn(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 C)
        {            
            const int rowstep = 4;
            for(var i=0; i< A.RowCount; i += rowstep)
            {
                A.GetCells(i, out Vec256<ulong> vx);
                B.GetCells(i, out Vec256<ulong> vy);
                dinx.vandn(vx,vy).StoreTo(ref C[i]);                
            }
            return ref C;
        }

        [MethodImpl(Inline)]
        public static BitMatrix64 andn(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix64.Alloc();
            return andn(A, B, ref C);
        }
    }
}