//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.Intrinsics;
    using System.Security;
    
    using static zfunc;

    partial class OpSkeleta
    {
        /// <summary>
        /// Base type for non-vectorized binary operators
        /// </summary>
        /// <typeparam name="A">The operand type</typeparam>
        public abstract class UnaryOp<A> : Op<A>, IUnaryOp<A>
        {
            public abstract A Invoke(A x);
        }

        /// <summary>
        /// Base type for vectorized binary operators
        /// </summary>
        /// <typeparam name="W">The vector bit width</typeparam>
        /// <typeparam name="V">The vector type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VUnaryOp<W, V, T> : VOp<W, V, T>, IVUnaryOp<W, V, T>
            where W : unmanaged, ITypeNat
            where V : struct
            where T : unmanaged
        {
            public abstract V Invoke(V a);
        }

        /// <summary>
        /// Base type for vectorized binary operators that are accompanied by componentwise decomposition/evaluation
        /// </summary>
        /// <typeparam name="W">The vector bit width</typeparam>
        /// <typeparam name="V">The vector type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VUnaryOpD<W,V,T> : VUnaryOp<W,V,T>, IVUnaryOpD<T>
            where W : unmanaged, ITypeNat
            where V : struct
            where T : unmanaged
        {
            public abstract T InvokeScalar(T a);
        }

        /// <summary>
        /// Base type for vectorized 128-bit binary operators
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VUnaryOp128<T> : VUnaryOp<N128, Vector128<T>, T>
            where T : unmanaged
        {

        }

        /// <summary>
        /// Base type for vectorized 128-bit binary operators are accompanied by componentwise decomposition/evaluation
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VUnaryOp128D<T> : VUnaryOpD<N128, Vector128<T>, T>, IVUnaryOp128D<T>
            where T : unmanaged
        {

        }

        /// <summary>
        /// Base type for vectorized 256-bit binary operators
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VUnaryOp256<T> : VUnaryOp<N256, Vector256<T>, T>
            where T : unmanaged
        {

        }

        /// <summary>
        /// Base type for vectorized 256-bit binary operators are accompanied by componentwise decomposition/evaluation
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VUnaryOp256D<T> : VUnaryOpD<N256, Vector256<T>, T>, IVUnaryOp256D<T>
            where T : unmanaged
        {

        }
    }
}