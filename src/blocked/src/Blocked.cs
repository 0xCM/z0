
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost("api")]
    public partial class Blocked
    {
        const NumericKind Closure = Integers;

        [MethodImpl(Inline)]
        static SpanBlock256<T> and<T>(in SpanBlock256<T> a, in SpanBlock256<T> b, SpanBlock256<T> dst)
            where T : unmanaged
        {
            for(var i=0u; i<a.BlockCount; i++)
                z.vsave(gvec.vand<T>(a.LoadVector(i), b.LoadVector(i)), ref dst.BlockRef(i));
            return dst;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] & rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static Block256<N,T> and<N,T>(Block256<N,T> lhs, Block256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var dst = RowVectors.blockalloc<N,T>();
            and<T>(lhs.Data, rhs.Data, dst);
            return dst;
        }

        /// <summary>
        /// Computes lhs[i] := lhs[i] + rhs[i] for i = 0...N-1
        /// </summary>
        /// <param name="lhs">The left operand which will be updated in-place</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The component type</typeparam>
        [MethodImpl(Inline)]
        public static ref Block256<N,T> add<N,T>(ref Block256<N,T> x, in Block256<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Blocked.add<T>(x,y,x);
            return ref x;
        }

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

    public partial class BSvcHosts
    {

    }

    [FunctionalService]
    public partial class BSvc : ISFxRoot<BSvc,BSvcHosts>
    {

    }
}