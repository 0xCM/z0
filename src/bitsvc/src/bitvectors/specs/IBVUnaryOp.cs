//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IBVUnaryOp<T> : IUnaryOp<BitVector<T>>
        where T : unmanaged
    {

    }

    public interface IBVUnaryOpD<T> : IBVUnaryOp<T>
        where T : unmanaged
    {
        T InvokeScalar(T a);
    }

}