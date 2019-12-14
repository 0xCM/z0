//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines Modular matrix operations
    /// </summary>
    /// <remarks>
    /// Algorithms taken from SSJ; see LICENSE file in this project root
    /// </remarks>
    public static class MatMod
    {
        /// <summary>
        /// Computes the vector u = As (mod m)
        /// </summary>
        /// <param name="A">The matrix operand</param>
        /// <param name="v">The vector to be transformed</param>
        /// <param name="u">The transformed vector</param>
        /// <param name="m">The modulus</param>
        public static ref RowVector<N,uint> mvmul<N>(in Matrix<N,uint> A, in RowVector<N,uint> v, uint m, ref RowVector<N,uint> u) 
            where N : unmanaged, ITypeNat
        {
            //var x = new uint[v.Length];
            var x = RowVector.alloc<N,uint>();

            for(var i = 0; i < u.Length; ++i) 
            for(int j = 0; j < v.Length; j++)
                x[i] = Mod.fma(A[i,j], v[j], x[i], m);

            for (var i = 0; i < u.Length; ++i)
                u[i] = x[i];
            return ref u;
        }

        /// <summary>
        /// Computes the vector v = As (mod m)
        /// </summary>
        /// <param name="A">The matrix operand</param>
        /// <param name="v">The vector to be transformed</param>
        /// <param name="u">The transformed vector</param>
        /// <param name="m">The modulus</param>
        public static ref RowVector<N,ulong> mvmul<N>(in Matrix<N,ulong> A, in RowVector<N,ulong> v, ulong m, ref RowVector<N,ulong> u) 
            where N : unmanaged, ITypeNat
        {
            //var x = new ulong[v.Length];
            var rc = A.RowCount;
            var cc = A.ColCount;
            var temp = RowVector.alloc<N,ulong>();
            for(var i = 0; i < rc;  ++i) 
            for(var j = 0; j < cc; j++)
                temp[i] = Mod.fma(A[i,j], v[j], temp[i], m);

            for (var i = 0; i < u.Length; ++i)
                u[i] = temp[i];
            
            return ref u;
        }

        /// <summary>
        /// Computes the vector u = Av (mod m)
        /// </summary>
        /// <param name="A">The matrix operand</param>
        /// <param name="v">The vector to be transformed</param>
        /// <param name="u">The transformed vector</param>
        /// <param name="m">The modulus</param>
        public static ref RowVector<N,double> mvmul<N>(in Matrix<N,double> A, in RowVector<N,double> v, double m, ref RowVector<N,double> u) 
            where N : unmanaged, ITypeNat
        {
            var x = new double[u.Length];
            for(var i = 0; i < u.Length; ++i) 
            for(var j = 0; j < v.Length; j++)
                x[i] = Mod.fma(A[i,j], v[j], x[i], m);

            for (var i = 0; i < u.Length;  ++i)
                u[i] = x[i];
            
            return ref u;
        }

        /// <summary>
        /// Computes the product of square matricies C = AB (mod m)
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <param name="m">The modulus</param>
        /// <typeparam name="N">The matrix order type</typeparam>
        public static ref Matrix<N,uint> mul<N>(in Matrix<N,uint> A, in Matrix<N,uint> B, uint m, ref Matrix<N,uint> C) 
            where N: unmanaged, ITypeNat
        {
            var rc = C.RowCount;
            var cc = C.ColCount;
            var W = Matrix.alloc<N,uint>();
            var v = RowVector.alloc<N,uint>();

            for (var i = 0; i < cc;  ++i) 
            {
                for (var j = 0; j < rc;  ++j)
                    v[j] = B[j,i];
                
                mvmul(A, v, m, ref v);
                
                for (var j = 0; j < rc;  ++j)
                    W[j,i] = v[j];
            }

            for (var i = 0; i < rc;  ++i) 
            for (var j = 0; j < cc;  ++j)
                C[i,j] = W[i,j];
            
            return ref C;
        }

        /// <summary>
        /// Computes the matrix product C = AB (mod m)
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The result matrix</param>
        /// <param name="m">The modulus</param>
        public static ref Matrix<N,ulong> mul<N>(in Matrix<N,ulong> A, in Matrix<N,ulong> B, ulong m, ref Matrix<N,ulong> C) 
            where N: unmanaged, ITypeNat
        {
            var rc = C.RowCount;
            var cc = C.ColCount;
            
            var W = Matrix.alloc<N,ulong>();
            var v = RowVector.alloc<N,ulong>();

            for (var i = 0; i < cc;  ++i) 
            {
                for (var j = 0; j < rc;  ++j)
                    v[j] = B[j,i];
                
                mvmul(A, v, m, ref v);
                
                for (var j = 0; j < rc;  ++j)
                    W[j,i] = v[j];
            }

            for (var i = 0; i < rc;  ++i) 
            for (var j = 0; j < cc;  ++j)
                C[i,j] = W[i,j];
            return ref C;
        }

        /// <summary>
        /// Computes the matrix product C = AB (mod m)
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The result matrix</param>
        /// <param name="m">The modulus</param>
        public static ref Matrix<N,double> mul<N>(in Matrix<N,double> A, in Matrix<N,double> B, double m, ref Matrix<N,double> C) 
            where N : unmanaged, ITypeNat
        {
            int r = C.RowCount;
            int c = B.ColCount;
            var V = RowVector.alloc<N,double>();
            var W = Matrix.alloc<N,double>();
            for (var i = 0; i < c;  ++i) 
            {
                for (var j = 0; j < r;  ++j)
                    V[j] = B[j,i];

                mvmul<N>(A, V, m, ref V);
            
                for (var j = 0; j < r; ++j)
                    W[j,i] = V[j];
            }

            for (var i = 0; i < r;  ++i) 
            for (var j = 0; j < c;  ++j)
                C[i,j] = W[i,j];          

            return ref C;  
        }

        /// <summary>
        /// Computes B = A^e (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,uint> pow<N>(in Matrix<N,uint> A, uint e, uint m, ref Matrix<N,uint> B) 
            where N : unmanaged, ITypeNat
        {
            
            var length = A.RowCount;
            var W = Matrix.alloc<N,uint>();

            /* initialize: W = A; B = I */
            for (var i = 0; i < length; i++) 
            for (var j = 0; j < length;  ++j)  
            {
                W[i,j] = A[i,j];
                B[i,j] = 0;
            }

            for (var j = 0; j < length;  ++j)
                B[j,j] = 1;

            /* Compute B = A^c mod m using the binary decomp. of c */
            var exp = e;
            while (exp > 0) 
            {
                if ((exp % 2)==1)
                    mul (W, B, m, ref B);
            
                mul (W, W, m, ref W);
                exp /= 2;
            }
            return ref B;
        }

        /// <summary>
        /// Computes B = A^e (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,ulong> pow<N>(in Matrix<N,ulong> A, uint e, ulong m, ref Matrix<N,ulong> B) 
            where N : unmanaged, ITypeNat
        {
            
            var length = A.RowCount;
            var W = Matrix.alloc<N,ulong>();

            /* initialize: W = A; B = I */
            for (var i = 0; i < length; i++) 
            for (var j = 0; j < length; ++j)  
            {
                W[i,j] = A[i,j];
                B[i,j] = 0;
            }

            for (var j = 0; j < length;  ++j)
                B[j,j] = 1;

            /* Compute B = A^c mod m using the binary decomp. of c */
            var exp = e;
            while (exp > 0) 
            {
                if ((exp % 2)==1)
                    mul (W, B, m, ref B);
            
                mul (W, W, m, ref W);
                exp /= 2;
            }
            return ref B;
        }

        /// <summary>
        /// Computes B = A^c (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,double> pow<N>(in Matrix<N,double> A, uint e, double m, ref Matrix<N,double> B) 
            where N : unmanaged, ITypeNat
        {
            int i, j;
            var n = e;
            var s = A.RowCount;
            var W = Matrix.alloc<N,double>();

            /* initialize: W = A; B = I */
            for (i = 0; i < s; i++) 
            {
                for (j = 0; j < s;  ++j)  
                {
                    W[i,j] = A[i,j];
                    B[i,j] = 0.0;
                }
            }

            for (j = 0; j < s;  ++j)
                B[j,j] = 1.0;

            /* Compute B = A^c mod m using the binary decomp. of c */
            while (n > 0) 
            {
                if ((n % 2)==1)
                    mul<N>(W, B, m, ref B);
            
                mul<N>(W, W,m, ref W);
                n /= 2;
            }
            return ref B;
        }

        /// <summary>
        /// Computes B = A^{2^e} (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The base-2 log of the exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,uint> pow2<N>(in Matrix<N,uint> A, uint e, uint m, ref Matrix<N,uint> B) 
            where N : unmanaged, ITypeNat
        {            
            /* initialize: B = A */
            var n = A.RowCount;
            if (A != B) 
            {
                for (var i = 0; i < n; i++) 
                for (var j = 0; j < n; ++j)
                    B[i,j] = A[i,j];
            }

            /* Compute B = A^{2^e} */
            for (var i = 0; i < e; i++)
                mul(B, B, m, ref B);
        
            return ref B;
        }

        /// <summary>
        /// Computes B = A^{2^e} (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The base-2 log of the exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,ulong> pow2<N>(in Matrix<N,ulong> A, uint e, ulong m, ref Matrix<N,ulong> B) 
            where N : unmanaged, ITypeNat
        {            
            /* initialize: B = A */
            var n = A.RowCount;
            if (A != B) 
            {
                for (var i = 0; i < n; i++) 
                for (var j = 0; j < n; ++j)
                    B[i,j] = A[i,j];
            }

            /* Compute B = A^{2^e} */
            for (var i = 0ul; i < e; i++)
                mul(B, B, m, ref B);

            return ref B;
        }

        /// <summary>
        /// Computes B = A^{2^e} (mod m)
        /// </summary>
        /// <param name="A">The source matrix</param>
        /// <param name="e">The base-2 log of the exponent</param>
        /// <param name="m">The modulus</param>
        /// <param name="B">The result matrix</param>
        public static ref Matrix<N,double> pow2<N>(in Matrix<N,double> A, uint e, double m, ref Matrix<N,double> B) 
            where N : unmanaged, ITypeNat
        {
            /* initialize: B = A */
            var n = A.RowCount;
            if (A != B) 
            {
                for (var i = 0; i < n; i++) 
                for (var j = 0; j < n; ++j)
                    B[i,j] = A[i,j];
            }

            /* Compute B = A^{2^e} */
            for (var i = 0; i < e; i++)
                mul<N>(B, B, m, ref B);
            return ref B;
        }
    }
}