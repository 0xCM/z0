//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static BitMatrix<T> xornot<T>(in BitMatrix<T> A, in BitMatrix<T> B)
            where T : unmanaged
        {
            var Z = BitMatrix.alloc<T>();
            BitSquare.xornot(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix<T> xornot<T>(in BitMatrix<T> A, in BitMatrix<T> B, ref BitMatrix<T> Z)
            where T : unmanaged
        {
            BitSquare.xornot(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix8 xornot(in BitMatrix8 A, in BitMatrix8 B, ref BitMatrix8 Z)
        {
            BitSquare.xornot(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static BitMatrix8 xornot(in BitMatrix8 A, in BitMatrix8 B)
        {
            var Z = BitMatrix.alloc(n8);
            BitSquare.xornot(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        [MethodImpl(Inline)]
        public static BitMatrix16 xornot(in BitMatrix16 A, in BitMatrix16 B)
        {
            var Z = BitMatrix.alloc(n16);
            BitSquare.xornot(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix16 xornot(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 Z)
        {
            BitSquare.xornot(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

        [MethodImpl(Inline)]
        public static BitMatrix32 xornot(in BitMatrix32 A, in BitMatrix32 B)
        {
            var Z = BitMatrix.alloc(n32);
            BitSquare.xornot(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix32 xornot(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 Z)
        {
            BitSquare.xornot(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }

         [MethodImpl(Inline)]
        public static BitMatrix64 xornot(in BitMatrix64 A, in BitMatrix64 B)
        {
            var Z = BitMatrix.alloc(n64);
            BitSquare.xornot(in A.Head, in B.Head, ref Z.Head);
            return Z;
        }

        [MethodImpl(Inline)]
        public static ref BitMatrix64 xornot(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 Z)
        {
            BitSquare.xornot(in A.Head, in B.Head, ref Z.Head);
            return ref Z;
        }
   }
}