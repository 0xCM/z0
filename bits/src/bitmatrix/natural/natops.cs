//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;

    using static zfunc;
    using static As;

    partial class BitMatrix
    {
        /// <summary>
        /// Allocates a 1-filled natural bitmatrix
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<M,N,T> ones<M,N,T>(M m = default, N n = default)
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
                => BitMatrix<M,N,T>.Ones();

        /// <summary>
        /// Allocates a 1-filled bitmatrix of natural order
        /// </summary>
        /// <typeparam name="M">The row dimension</typeparam>
        /// <typeparam name="N">The column dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> ones<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
        {                    
            Span<T> data = new T[n.value];
            data.Fill(gmath.one<T>());
            return load(n,data);
        }

        /// <summary>
        /// Allocates an identity bitmatrix of natural order
        /// </summary>
        /// <typeparam name="N">The column/row dimension</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        public static BitMatrix<N,T> identity<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
       {            
            var dst = natural<N,T>();
            var order  = (int)n.value;
            for(var i = 0; i< order; i++)
                dst[i,i] = true;            
            return dst;
        }    

        /// <summary>
        /// Defines the specification grid for a natural square bitmatrix
        /// </summary>
        /// <param name="n">The matrix order</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The primal type over which the matrix is defined</typeparam>
        [MethodImpl(Inline)]
        public static GridSpec<T> grid<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                => new GridSpec<T>(bitsize<T>(), (int)n.value,(int)n.value);

        [MethodImpl(Inline)]
        public static GridLayout<T> layout<N,T>()
            where N : ITypeNat,new()
            where T : unmanaged
                => grid<N,T>().CalcLayout();

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
            var C = natural<N,T>();
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

        /// <summary>
        /// Computes the bitwise OR between two square bitmatrices of common natural order and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<N,T> or<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> C)        
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.or(A.Data, B.Data, C.Data);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise OR between two bitmatrices of common natural dimension and stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operand</param>
        /// <param name="B">The second source operand</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<M,N,T> or<M,N,T>(in BitMatrix<M,N,T> A, in BitMatrix<M,N,T> B, ref BitMatrix<M,N,T> C)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.or(A.Data, B.Data, C.Data);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise compliement of entries in the source matrix not stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static BitMatrix<N,T> not<N,T>(BitMatrix<N,T> A, BitMatrix<N,T> B)        
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.not(A.Data, B.Data);
            return  B;
        }

        /// <summary>
        /// Computes the bitwise compliement of entries in the source matrix not stores the
        /// result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="B">The target matrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static  BitMatrix<M,N,T> not<M,N,T>(BitMatrix<M,N,T> A, BitMatrix<M,N,T> B)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.not(A.Data,B.Data);
            return B;
        }

        /// <summary>
        /// Computes the bitwise XOR between two square bitmatrices of common natural order xor stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operxor</param>
        /// <param name="B">The second source operxor</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<N,T> xor<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> C)        
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.xor(A.Data, B.Data, C.Data);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise XOR between two bitmatrices of common natural dimension xor stores the
        /// result a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The first source operxor</param>
        /// <param name="B">The second source operxor</param>
        /// <param name="C">The target</param>
        /// <typeparam name="N">The matrix order</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        [MethodImpl(Inline)]
        public static ref BitMatrix<M,N,T> xor<M,N,T>(in BitMatrix<M,N,T> A, in BitMatrix<M,N,T> B, ref BitMatrix<M,N,T> C)        
            where M : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            mathspan.xor(A.Data, B.Data, C.Data);
            return ref C;
        }


        /// <summary>
        /// Computes the product of bitmatrices of comparible natural dimensions and stores the
        /// result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        public static ref BitMatrix<M, N, T> mul<M,P,N,T>(in BitMatrix<M,P,T> A, in BitMatrix<P,N,T> B, ref BitMatrix<M,N,T> C)
            where M : ITypeNat, new()
            where P : ITypeNat, new()
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var x = A;
            var y = B.Transpose();
            var n = (int)new N().value;
            for(var i=0; i<n; i++)
            {
                var row = x.RowVector(i);
                for(var j=0; j<n; j++)
                    C[i,j] = row % y.RowVector(j);
            }

            return ref C;
        }

        /// <summary>
        /// Computes the product of square bitmatrices of common natural order and stores the result to a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="N">The order type</typeparam>
        /// <typeparam name="T">The matrix storage type</typeparam>
        public static ref BitMatrix<N,T> mul<N,T>(in BitMatrix<N,T> A, in BitMatrix<N,T> B, ref BitMatrix<N,T> C)
            where N : ITypeNat, new()
            where T : unmanaged
        {
            var tr = B.Transpose();
            var n = (int)new N().value;
            for(var i=0; i<n; i++)
            {
                var row = A[i];
                for(var j=0; j<n; j++)
                    C[i,j] = row % tr.RowVector(j);
            }

            return ref C;
        }

        /// <summary>
        /// Projects the bits of a generic sqare bitmatix of natural order into a generic target matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="N">The orer type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<N, T> unpack<N,S,T>(BitMatrix<N,S> src, ref Matrix<N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where N : ITypeNat, new()
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a generic bitmatix of natural dimensions into a generic matrix of the same dimensions
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
        [MethodImpl(Inline)]
        public static ref Matrix<M, N, T> unpack<M,N,S,T>(BitMatrix<M,N,S> src, ref Matrix<M,N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            gbits.unpack(src.Data, dst.Data.AsSpan());            
            return ref dst;
        }


        /// <summary>
        /// Projects the bits of a square generic bitmatix of natural order into a generic block matrix of the same order
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
        [MethodImpl(Inline)]
        public static ref BlockMatrix<N, T> unpack<N,S,T>(BitMatrix<N,S> src, ref BlockMatrix<N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where N : ITypeNat, new()
        {
            gbits.unpack(src.Data, dst.Unblocked);            
            return ref dst;
        }

        /// <summary>
        /// Projects the bits of a generic bitmatix of natural dimensions into a generic block matrix of the same dimensions
        /// </summary>
        /// <param name="src">The source matrix</param>
        /// <param name="dst">The target metrix</param>
        /// <typeparam name="M">The row dimension type</typeparam>
        /// <typeparam name="N">The col dimension type</typeparam>
        /// <typeparam name="S">The source matrix element type</typeparam>
        /// <typeparam name="T">The target matrix element type</typeparam>
       [MethodImpl(Inline)]
        public static ref BlockMatrix<M,N,T> unpack<M,N,S,T>(BitMatrix<M,N,S> src, ref BlockMatrix<M,N,T> dst)
            where S : unmanaged
            where T : unmanaged
            where M : ITypeNat, new()
            where N : ITypeNat, new()
        {
            gbits.unpack(src.Data, dst.Unblocked);            
            return ref dst;
        }
         
 
    }

}