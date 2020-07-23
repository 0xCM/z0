//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst; 
    using static z;

    partial class Blocked
    {
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block128<T> sub<T>(in Block128<T> a, in Block128<T> b, in Block128<T> dst)
            where T : unmanaged
                => ref BSvc.sub<T>(w128).Invoke(a, b, dst);

        [MethodImpl(Inline), Op, Closures(Integers)]
        public static ref readonly Block256<T> sub<T>(in Block256<T> a, in Block256<T> b, in Block256<T> dst)
            where T : unmanaged
                => ref BSvc.sub<T>(w256).Invoke(a, b, dst);

        /// <summary>
        /// Computes z[i] := x[i] - y[i] for i = 0...N-1
        /// </summary>
        /// <param name="x">The left vector</param>
        /// <param name="y">The right vector</param>
        /// <param name="z">The target vector</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Block256<N,T> sub<N,T>(Block256<N,T> x, Block256<N,T> y, ref Block256<N,T> z)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            Blocked.sub(x.Data, y.Data, z.Data);
            return ref z;
        }
    }
}