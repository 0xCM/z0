//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Components;

    public interface IVectorKind : IKind
    {

    }

    public interface IVectorType : IVectorKind, IFixedWidth
    {

    }    

    public interface IVectorType<V,T> : ITypeKind<T>, IVectorType
        where V : struct
        where T : unmanaged
    {

    }

    public readonly struct VectorTypeKind : IVectorKind
    {

    }        
}