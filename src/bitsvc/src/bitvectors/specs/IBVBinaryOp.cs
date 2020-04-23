//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IBVBinaryOp<T> : ISBinaryOp<BitVector<T>>
        where T : unmanaged
    {

    }

    public interface IBVBinaryOpD<T> : IBVBinaryOp<T>
        where T : unmanaged
    {
        T InvokeScalar(T a, T b);
    }

}