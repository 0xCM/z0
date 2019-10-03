//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
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


        public static BitMatrix64 andn(in BitMatrix64 A, in BitMatrix64 B)
        {
            var C = BitMatrix64.Alloc();
            return andn(A,B, ref C);
        }
    }
}