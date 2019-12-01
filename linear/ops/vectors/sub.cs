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
        /// Computes z[i] := x[i] - y[i] for i = 0...N-1
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<N,T> sub<N,T>(VBlock256<N,T> x, VBlock256<N,T> y, ref VBlock256<N,T> z)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            vblock.sub(x.Data,y.Data,z.Data);
            return ref z;
        }

        /// <summary>
        /// Computes the result x[i] - y[i] for i = 0...N
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VBlock256<N,T> sub<N,T>(VBlock256<N,T> x, VBlock256<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var dst = x.Replicate();
            sub(x,y, ref dst);
            return dst;
        }

        /// <summary>
        /// Computes z[i] := x[i] - y[i] for i = 0...n-1 where n is the (presumed) common length of the operands 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref VBlock256<T> sub<T>(VBlock256<T> x, VBlock256<T> y, ref VBlock256<T> z)
            where T : unmanaged
        {
            mathspan.sub(x.Unblocked, y.Unblocked, z.Unblocked);
            return ref z;
        }

        /// <summary>
        /// Computes the result x[i] - y[i] for i = 0...n-1 where n is the (presumed) common length of the operands 
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static VBlock256<T> sub<T>(VBlock256<T> x, VBlock256<T> y)
            where T : unmanaged
        {                
            var z = x.Replicate();
            return sub(x,y,ref z);
        }
    }
}