//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Root;
    using static OpSkeleta;

    public static class AndSkeleton
    {
        public abstract class CAnd<W,V,T> : VBinOpD<W,V,T>
            where W : unmanaged, ITypeNat
            where V : struct
            where T : unmanaged
        {
            public const string Name = "vand";

            [MethodImpl(Inline)]
            public override T InvokeScalar(T a, T b) => gmath.and(a,b);

            [MethodImpl(Inline)]
            protected override string GetOpName() => Name;
        }

        public sealed class CAnd128<T> : CAnd<N128,Vector128<T>,T>
            where T : unmanaged
        {
            public static CAnd128<T> Op => new CAnd128<T>();

            [MethodImpl(Inline)]
            public override Vector128<T> Invoke(Vector128<T> x, Vector128<T> y) => ginx.vand(x,y);
        }

        public sealed class CAnd256<T> : CAnd<N256,Vector256<T>,T>
            where T : unmanaged
        {
            public static CAnd256<T> Op => new CAnd256<T>();

            [MethodImpl(Inline)]
            public override Vector256<T> Invoke(Vector256<T> x, Vector256<T> y) => ginx.vand(x,y);
        }

    }

    public static class OpSkeleta
    {
        public abstract class Op<A> : IFunc
        {
            protected abstract string GetOpName();

            public virtual OpIdentity Id => OpIdentity.contracted<A>(GetOpName());
        }

        /// <summary>
        /// Base type for homogenous vectorized operators
        /// </summary>
        /// <typeparam name="W">The vector bit width</typeparam>
        /// <typeparam name="V">The vector type</typeparam>
        /// <typeparam name="T">The vector component type</typeparam>
        public abstract class VOp<W,V,T> : Op<V>
            where W : unmanaged, ITypeNat
            where V : struct
            where T : unmanaged
        {
            protected static W w => default;

            protected static T t => default;

            public override OpIdentity Id => NaturalIdentity.contracted<W,T>(GetOpName());
        }

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