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
        public abstract class BinOp<A> : Op<A>, IBinaryOp<A>
        {
            public abstract A Invoke(A x, A y);
        }

        /// <summary>
        /// Base type for vectorized binary operators
        /// </summary>
        /// <typeparam name="W">The vector bit width</typeparam>
        /// <typeparam name="V">The vector type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VBinOp<W, V, T> : VOp<W, V, T>, IVBinOp<W, V, T>
            where W : unmanaged, ITypeNat
            where V : struct
            where T : unmanaged
        {
            public abstract V Invoke(V a, V b);
        }

        /// <summary>
        /// Base type for vectorized binary operators that are accompanied by componentwise decomposition/evaluation
        /// </summary>
        /// <typeparam name="W">The vector bit width</typeparam>
        /// <typeparam name="V">The vector type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VBinOpD<W,V,T> : VBinOp<W,V,T>, IVBinOpD<T>
            where W : unmanaged, ITypeNat
            where V : struct
            where T : unmanaged
        {
            public abstract T InvokeScalar(T a, T b);
        }

        /// <summary>
        /// Base type for vectorized 128-bit binary operators
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VBinOp128<T> : VBinOp<N128, Vector128<T>, T>
            where T : unmanaged
        {

        }

        /// <summary>
        /// Base type for vectorized 128-bit binary operators are accompanied by componentwise decomposition/evaluation
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VBinOp128D<T> : VBinOpD<N128, Vector128<T>, T>, IVBinOp128D<T>
            where T : unmanaged
        {

        }

        /// <summary>
        /// Base type for vectorized 256-bit binary operators
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VBinOp256<T> : VBinOp<N256, Vector256<T>, T>
            where T : unmanaged
        {

        }

        /// <summary>
        /// Base type for vectorized 256-bit binary operators are accompanied by componentwise decomposition/evaluation
        /// </summary>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VBinOp256D<T> : VBinOpD<N256, Vector256<T>, T>, IVBinOp256D<T>
            where T : unmanaged
        {

        }
    }
}