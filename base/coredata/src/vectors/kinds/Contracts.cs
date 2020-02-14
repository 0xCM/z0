//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface IVectorType : ITypeKind
    {

    }

    public interface IFixedVectorType : IVectorType, IFixedWidth
    {

    }    

    public interface IFixedVectorType<F> : IFixedVectorType, IFixedKind<F>
        where F : unmanaged, IFixed
    {

    }

    public interface IVectorType<T> : IVectorType, ITypeKind<T>
        where T : unmanaged
    {

    }

    public interface IVectorType<V,T> : ITypeKind<T>, IFixedVectorType
        where T : unmanaged
        where V : struct
    {

    }
}