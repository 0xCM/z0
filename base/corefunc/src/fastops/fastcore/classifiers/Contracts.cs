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
    /// Characterizes an enumeration-classified kind
    /// </summary>
    /// <typeparam name="K">The classifying enumeration type</typeparam>
    public interface IKind<K>
        where K : unmanaged, Enum
    {
        /// <summary>
        /// The classification value
        /// </summary>
        K Classifier {get;}
    }

    public interface IBlockClass : IKind<BlockKind>
    {


    }

    public interface IBlockClass<W,T> : IBlockClass
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {

    }


    /// <summary>
    /// Characterizes types/kinds with which a fixed bit-width is associated
    /// </summary>
    public interface IFixedClass : IKind<FixedWidth>
    {

        FixedWidth FixedWidth {get;}

        FixedWidth IKind<FixedWidth>.Classifier 
        {
             [MethodImpl(Inline)]
             get  => FixedWidth;
        }
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


    public interface IPrimalClass : IKind<PrimalKind>
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