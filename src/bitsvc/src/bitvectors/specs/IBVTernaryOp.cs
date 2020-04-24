//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IBVTernaryOp<T> : ITernaryOp<BitVector<T>>
        where T : unmanaged
    {

    }

    public interface IBVTernaryOpD<T> : IBVTernaryOp<T>
        where T : unmanaged
    {

        T InvokeScalar(T a, T b, T c);
    }    
}