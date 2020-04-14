//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IBVBinaryPred<T> : ISFuncApi<BitVector<T>,BitVector<T>,bit>
        where T : unmanaged
    {

    }

    public interface IBVBinaryPredD<T> : IBVBinaryPred<T>
        where T : unmanaged
    {
        bit InvokeScalar(T a, T b);
    }

}