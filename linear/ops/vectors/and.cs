//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    partial class Linear
    {
        /// <summary>
        /// Computes lhs[i] := lhs[i] & rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VBlock256<N,T> and<N,T>(VBlock256<N,T> lhs, VBlock256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var dst = Vector.blockalloc<N,T>();
            and<T>(lhs.Data, rhs.Data, dst);
            return dst;
        }

        public static Block256<T> and<T>(ConstBlock256<T> lhs, ConstBlock256<T> rhs, Block256<T> dst)
            where T : unmanaged
        {
            for(var i=0; i< blocks(lhs,rhs); i++)
                vstore(ginx.vand<T>(lhs.LoadVector(i), rhs.LoadVector(i)), ref dst.BlockSeek(i));                             
            return dst;        
        } 


        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> and<N,T>(VBlock256<N,T> lhs, VBlock256<N,T> rhs, ref VBlock256<N,T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            and<T>(lhs.Data, rhs.Data, dst);
            return ref dst;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VBlock256<N,T> and<N,T>(VBlock256<N,T> lhs, T rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var dst = lhs.Replicate();
            mathspan.and(dst.Data, rhs);
            return dst;            
        }

        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> and<N,T>(VBlock256<N,T> lhs, T rhs, ref VBlock256<N,T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            lhs.Data.CopyTo(dst.Data);
            mathspan.and(dst.Data, rhs);
            return ref dst;            
        }

    }
}