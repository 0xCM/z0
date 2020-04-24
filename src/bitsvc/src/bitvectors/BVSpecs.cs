//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial class BV
    {
        public interface IUnaryOp<T> : Z0.IUnaryOp<BitVector<T>>
            where T : unmanaged
        {
            T Invoke(T a);
        }        
        
        public interface IBinaryOp<T> : Z0.IBinaryOp<BitVector<T>>
            where T : unmanaged
        {
            T Invoke(T a, T b);
        }

        public interface ITernaryOpBV<T> : Z0.ITernaryOp<BitVector<T>>
            where T : unmanaged
        {

            T Invoke(T a, T b, T c);
        }    

        public interface IUnaryPredBV<T> : Z0.IFunc<BitVector<T>, bit>
            where T : unmanaged
        {
            bit Invoke(T a);
        }        

        public interface IBinaryPred<T> : Z0.IFunc<BitVector<T>,BitVector<T>,bit>
            where T : unmanaged
        {
            bit Invoke(T a, T b);
        }

    }
}