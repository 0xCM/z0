//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    /// <summary>
    /// Identifies a higher-kinded representation
    /// </summary>
    public interface IKind
    {

    }

    /// <summary>
    /// Characterizes a kind with parametric classification
    /// </summary>
    /// <typeparam name="K">The classifying type</typeparam>
    public interface IKind<K> : IKind
    {
        /// <summary>
        /// The classification value
        /// </summary>
        K Classifier {get;}
    }

    /// <summary>
    /// Characterizes a kind with doubly-parametric clasification
    /// </summary>
    /// <typeparam name="K1">The first classifying type</typeparam>
    /// <typeparam name="K1">The second classifying type</typeparam>
    public interface IKind<K1,K2>  : IKind<Pair<K1,K2>>
    {
        /// <summary>
        /// The classification value
        /// </summary>
        K1 Class1 {get;}

        /// <summary>
        /// The classification value
        /// </summary>
        K2 Class2 {get;}

        Pair<K1,K2> IKind<Pair<K1,K2>>.Classifier
            => paired(Class1,Class2);
    }

    /// <summary>
    /// Characterizes a higher-kinded type representation
    /// </summary>
    public interface ITypeKind : IKind<TypeKind>
    {        
    }
    
    public interface IParametricTypeKind : ITypeKind
    {

    }
    
    public interface ITypeKind<T> : IParametricTypeKind
    {

    }

    public interface ITypeKind<T1,T2> : IParametricTypeKind
    {

    }

    public interface ITypeKind<T1,T2,T3> : IParametricTypeKind
    {

    }

    public interface ITypeKindN<N> : ITypeKind
        where N : unmanaged, ITypeNat
    {
        int NaturalArity
        {
            [MethodImpl(Inline)]
            get => (int)nateval<N>();
        }
    }

    public interface ITypeKindN1<N> : ITypeKindN<N1>, ITypeKind<N>
        where N : unmanaged, ITypeNat
    {

    }

    public interface ITypeKindN1<N,T> : ITypeKindN<N1>, ITypeKind<N,T>
        where N : unmanaged, ITypeNat
    {

    }

    public interface ITypeKindN1<N,T1,T2> : ITypeKindN<N1>, ITypeKind<N,T1,T2>
        where N : unmanaged, ITypeNat
    {

    }

    public interface ITypeKindN2<M,N> : ITypeKindN<N2>, ITypeKind<M,N>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
    {

    }

    public interface ITypeKindN2<M,N,T> : ITypeKindN<N2>, ITypeKind<M,N>
        where M : unmanaged, ITypeNat
        where N : unmanaged, ITypeNat
    {

    }

    public interface IFixedWidth
    {
        FixedWidth FixedWidth {get;}
    }

    /// <summary>
    /// Characterizes a realization that is naturally-parametric with natural widths that can be specified as a fixed-width
    /// </summary>
    /// <typeparam name="W">The natural width type</typeparam>
    public interface IFixedNatWidth<W> : IFixedWidth
        where W : unmanaged, ITypeNat
    {
        FixedWidth IFixedWidth.FixedWidth
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)nateval<W>();
        }

    }

    public interface INatKind : ITypeKind
    {

        TypeKind IKind<TypeKind>.Classifier
        {
            [MethodImpl(Inline)]
            get => TypeKind.NatType;
        }
    }

    public interface INatKind<N> : INatKind
        where N : unmanaged, ITypeNat
    {
        ulong Value 
        {
            [MethodImpl(Inline)]
            get => nateval<N>();
        }
    }

    public interface IVecKind : ITypeKind
    {
        TypeKind IKind<TypeKind>.Classifier
        {
            [MethodImpl(Inline)]
            get => TypeKind.VectorType;
        }

    }

    public interface IFixedVecKind : IVecKind, IFixedWidth
    {

    }    
    public interface IFixedVecKind<F> : IFixedVecKind, IFixedKind<F>
        where F : unmanaged, IFixed
    {

    }
    public interface IVecKind<T> : ITypeKind<T>
        where T : unmanaged
    {

    }

    public interface IVecKind<V,T> : ITypeKind<T>, IFixedVecKind
        where T : unmanaged
        where V : struct
    {

    }

    public interface IBlockedKind : IKind<BlockKind>, ITypeKind
    {
        TypeKind IKind<TypeKind>.Classifier
        {
            [MethodImpl(Inline)]
            get => TypeKind.BlockedType;
        }

    }

    public interface IBlockedKind<W,T> : IBlockedKind, IFixedNatWidth<W>
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {

    }

    public interface IFixedBlockKind<W,F> : IBlockedKind<W,F>
        where W : unmanaged, ITypeNat
        where F : unmanaged, IFixed
    {

    }

    public interface IOperatorKind
    {
        string Name {get;}
    }

    public interface IOperatorKind<K> : IOperatorKind
        where K : unmanaged, IOperatorKind<K>
    {
        string IOperatorKind.Name => typeof(K).Name.ToLower();
    }    
}