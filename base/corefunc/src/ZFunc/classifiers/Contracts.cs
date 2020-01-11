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

    public interface IKind<K>
        where K : unmanaged, Enum
    {
        K Classifier {get;}
    }

    public interface IVectorKind : IKind<VectorKind>
    {

    }

    public interface IVectorKind<V> : IVectorKind
        where V : struct
    {

    }

    public interface IVectorKind<W,T> : IVectorKind
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {

    }

    public interface IBlockKind : IKind<BlockKind>
    {


    }

    public interface IBlockKind<B> : IBlockKind
        where B : struct
    {


    }

    public interface IBlockKind<W,T> : IBlockKind
        where W : unmanaged, ITypeNat
        where T : unmanaged
    {

    }

    public interface IPrimalKind : IKind<PrimalKind>
    {

    }

    public interface IPrimalKind<T> : IPrimalKind
        where T : unmanaged
    {

    }
}