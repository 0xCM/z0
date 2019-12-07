//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
    using System.Text;

    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Defines reference operations related to matrix/vector multiplication
    /// </summary>
    public static class MatrixRefOps
    {
        public static TableSpan<M,P,double> Mul<M,N,P>(TableSpan<M,N,double> lhs, TableSpan<N,P,double> rhs)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where P : unmanaged, ITypeNat
        {
            var m = nati<M>();
            var n = nati<N>();
            var p = nati<P>();
            var dst = TableSpan.alloc<M,P,double>();
            for(var r = 0; r< m; r++)
                for(var c = 0; c < p; c++)
                    for(var i=0; i<nati<N>(); i++)
                        dst[r,c] += lhs[r,i] * rhs[i,c];
                                    
            return dst;
        }

        public static ref MBlock256<N,T> Mul<N,T>(MBlock256<N,T> A, MBlock256<N,T> B, ref MBlock256<N,T> X)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var n = nati<N>();
            for(var i = 0; i< n; i++)
            for(var j = 0; j< n; j++)
                X[i,j] = dot(A.Row(i), B.Col(j));                    
            return ref X;
        }


        public static ref MBlock256<M,N,T> Mul<M,K,N,T>(MBlock256<M,K,T> A, MBlock256<K,N,T> B, ref MBlock256<M,N,T> X)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var m = nati<M>();
            var n = nati<N>();
            for(var i = 0; i< m; i++)
            for(var j = 0; j< n; j++)
                X[i,j] = dot(A.GetRow(i), B.GetCol(j));         
            return ref X;           
        }

        public static MBlock256<M,N,T> Mul<M,K,N,T>(MBlock256<M,K,T> A, MBlock256<K,N,T> B)
            where M : unmanaged, ITypeNat
            where K : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var X = Matrix.blockalloc<M,N,T>();
            Mul(A,B, ref X);
            return X;
        }

        /// <summary>
        /// Commputes the canonical scalar product btween two vectors
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The natural type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        static T dot<N,T>(in VBlock256<N,T> lhs, in VBlock256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => mathspan.dot<T>(lhs.Unsized,rhs.Unsized);

        public static void Mul<M,N,T>(MBlock256<M,N,T> A, VBlock256<N,T> B, VBlock256<M,T> X)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var m = nati<M>();
            for(var i = 0; i< m; i++)
                X[i] = dot(A.GetRow(i), B);                    
        }

    }

}