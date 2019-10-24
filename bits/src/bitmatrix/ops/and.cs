//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        [MethodImpl(Inline)]
        public static BitMatrix4 and(in BitMatrix4 A, in BitMatrix4 B)
        {
            var a = (ushort)A;
            var b = (ushort)B;
            var c = math.and(a,b);
            return BitMatrix4.From(c);
        }

        [MethodImpl(Inline)]
        public static BitMatrix8 and(in BitMatrix8 A, in BitMatrix8 B)
        {
            var x = A.Bytes.TakeUInt64();
            var y = B.Bytes.TakeUInt64();
            return BitMatrix8.From(x & y);
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix16 and(in BitMatrix16 A, in BitMatrix16 B, ref BitMatrix16 C)
        {
            BitPoints256.and(refptr(ref A.Head), refptr(ref B.Head), refptr(ref C.Head));
            return ref C;
        }

        [MethodImpl(Inline)]
        public static BitMatrix16 and(in BitMatrix16 A, in BitMatrix16 B)
        {
            var C = BitMatrix16.Alloc();
            return and(A,B, ref C);
        }
        
        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix32 and(in BitMatrix32 A, in BitMatrix32 B, ref BitMatrix32 C)
        {
            BitPoints256.and(refptr(ref A.Head), refptr(ref B.Head), refptr(ref C.Head));
            return ref C;
        }

        [MethodImpl(Inline)]
        public static BitMatrix32 and(in BitMatrix32 A, in BitMatrix32 B)
        {
            var C = BitMatrix32.Alloc();
            return and(A,B, ref C);
        }

        [MethodImpl(Inline)]
        public static unsafe ref BitMatrix64 and(in BitMatrix64 A, in BitMatrix64 B, ref BitMatrix64 C)
        {
            BitPoints256.and(refptr(ref A.Head), refptr(ref B.Head), refptr(ref C.Head));
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise AND between two square bitmatrices of common natural order and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<N,T> and<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> C)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.and(A.Data, B.Data, C.Data);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise AND between two square bitmatrices of common order
        /// </summary>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> and<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var C = alloc<N,T>();
            return and(in A, in B, ref C);
        }

        /// <summary>
        /// Computes the bitwise AND between two bitmatrices of common dimension and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<M,N,T> and<M,N,T>(in BitMatrix<M,N,T> A, in BitMatrix<M,N,T> B, ref BitMatrix<M,N,T> C)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.and(A.Data, B.Data, C.Data);
            return ref C;
        } 
 
    }
}