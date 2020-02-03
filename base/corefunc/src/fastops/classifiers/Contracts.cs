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
    /// Characterizes types/kinds with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedClass : IKind
    {

        FixedWidth FixedWidth {get;}
    }

    public interface IFixedClass<F> : IFixedClass, IKind<FixedKind>
        where F : unmanaged, IFixed
    {
        FixedWidth IFixedClass.FixedWidth 
        {
            [MethodImpl(Inline)]
            get =>  (FixedWidth)bitsize<F>();
        }
   
        FixedKind IKind<FixedKind>.Classifier 
        {
             [MethodImpl(Inline)]
             get  => (FixedKind)FixedWidth;
        }
    }

    public interface IFixedClass<F,T> : IFixedClass, IKind<FixedKind,NumericKind>
        where F : unmanaged, IFixed
        where T : unmanaged
    {
        FixedWidth IFixedClass.FixedWidth 
        {
            [MethodImpl(Inline)]
            get => (FixedWidth)bitsize<F>();
        }

        /// <summary>
        /// The classification value
        /// </summary>
        FixedKind IKind<FixedKind,NumericKind>.Class1 
        {
            [MethodImpl(Inline)]
            get => (FixedKind)FixedWidth;
        }

        /// <summary>
        /// The classification value
        /// </summary>
        NumericKind IKind<FixedKind,NumericKind>.Class2 
        {
            [MethodImpl(Inline)]
            get => NumericType.kind<T>();
        }
    }

    public interface IBlockClass : IKind<BlockKind>
    {


    }

    public interface IBlockClass<W,T> : IBlockClass
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {

    }

    public interface IOpClass
    {
        string Name {get;}
    }

    public interface IOpClass<K> : IOpClass
        where K : unmanaged, IOpClass<K>
    {
        string IOpClass.Name => typeof(K).Name.ToLower();
    }    


    public interface IPrimalClass : IKind<NumericKind>
    {

    }

    public interface IPrimalClass<T> : IPrimalClass
        where T : unmanaged
    {

    }

    public interface IVectorClass : IKind<VectorKind>
    {

    }

    public interface IVectorClass<W,T> : IVectorClass
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {

    }    
}