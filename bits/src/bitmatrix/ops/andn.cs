//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static ref BitMatrix8 andn(ref BitMatrix8 A, in BitMatrix8 B)
        {
             BitConverter.GetBytes(~(ulong)A & (ulong)B).CopyTo(A.Bytes);
             return ref A;
        }

        [MethodImpl(Inline)]
        public static BitMatrix8 andn(BitMatrix8 A, BitMatrix8 B)
        {
            var C = A.Replicate();
            return andn(ref C, B);
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix16 andn(ref BitMatrix16 A, in BitMatrix16 B)
        {
            A.Load(out Vector256<ushort> x);
            B.Load(out Vector256<ushort> y);
            dinx.vandn(x,y).StoreTo(ref A[0]);
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
                A.Load(i, out Vector256<uint> x);
                B.Load(i, out Vector256<uint> y);
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