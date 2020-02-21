//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface IVectorKind : ITypeKind
    {

    }

    public interface IVectorType : IVectorKind, IFixedWidth
    {

    }    

    public interface IVectorType<F> : IVectorType, IFixedKind<F>
        where F : unmanaged, IFixed
    {

    }

    public interface IVectorType<V,T> : ITypeKind<T>, IVectorType
        where V : struct
        where T : unmanaged
    {

    }
}