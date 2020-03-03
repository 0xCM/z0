//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    public interface IBVUnaryOp<T> : IUnaryOp<BitVector<T>>
        where T : unmanaged
    {

    }

    public interface IBVUnaryOpD<T> : IBVUnaryOp<T>
        where T : unmanaged
    {
        T InvokeScalar(T a);
    }

    public interface IBVBinaryOp<T> : IBinaryOp<BitVector<T>>
        where T : unmanaged
    {

    }

    public interface IBVBinaryOpD<T> : IBVBinaryOp<T>
        where T : unmanaged
    {
        T InvokeScalar(T a, T b);
    }

    public interface IBVUnaryPred<T> : IUnaryPred<BitVector<T>>
        where T : unmanaged
    {

    }

    public interface IBVUnaryPredD<T> : IBVUnaryPred<T>
        where T : unmanaged
    {
        bit InvokeScalar(T a);
    }


    public interface IBVBinaryPred<T> : IBinaryPred<BitVector<T>>
        where T : unmanaged
    {

    }

    public interface IBVBinaryPredD<T> : IBVBinaryPred<T>
        where T : unmanaged
    {
        bit InvokeScalar(T a, T b);
    }

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