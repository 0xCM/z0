//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class Linear
    {
        /// <summary>
        /// Allocates a new vector from the result of adding a specified scalar value 
        /// to each source vector component
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="scalar">The scalar value</param>
        /// <typeparam name="N">The vector dimension type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static VBlock256<N,T> add<N,T>(VBlock256<N,T> src, T scalar)
            where N : unmanaged, ITypeNat            
            where T : unmanaged   
        { 
            var dst = src.Replicate();
            add(src, scalar, ref dst);
            return dst;            
        }

        /// <summary>
        /// Adds a specified scalar value to each source vector component and writes the result to
        /// a caller-supplied target vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="scalar">The scalar value</param>
        /// <param name="dst">The arget vector</param>
        /// <typeparam name="N">The vector dimension type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> add<N,T>(VBlock256<N,T> src, T scalar, ref VBlock256<N,T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
             src.Data.CopyTo(dst.Data);
             mathspan.add(dst.Unsized, scalar);
             return ref dst;
        }

        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> add<N,T>(VBlock256<N,T> x, VBlock256<N,T> y, ref VBlock256<N,T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            vblock.add(x.Data, y.Data, dst.Data);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static VBlock256<N,T> add<N,T>(VBlock256<N,T> x, VBlock256<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var dst = x.Replicate();
            return add(x, y, ref dst);
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<T> add<T>(ref VBlock256<T> lhs, in VBlock256<T> rhs)            
            where T : unmanaged
        {
            mathspan.add(lhs.Unblocked, rhs.Unblocked);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> add<N,T>(ref VBlock256<N,T> lhs, in T rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            mathspan.add(lhs.Unsized, rhs);
            return ref lhs;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> add<N,T>(ref VBlock256<N,T> x, in VBlock256<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            vblock.add<T>(x,y,x);
            return ref x;
        }

        /// <summary>
        /// Add the first vector to the second and populates the third with the result
        /// </summary>
        /// <param name="x">The first source vector</param>
        /// <param name="y">The second source vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="N">The vector length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> add<N,T>(in VBlock256<N,T> x, in VBlock256<N,T> y, ref VBlock256<N,T> z)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            mathspan.add(x.Unsized, y.Unsized, z.Unsized);
            return ref z;
        }
    }
}