//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    public interface IBVUnaryPred<T> : ISFuncApi<BitVector<T>, bit>
        where T : unmanaged
    {

    }

    public interface IBVUnaryPredD<T> : IBVUnaryPred<T>
        where T : unmanaged
    {
        bit InvokeScalar(T a);
    }
}