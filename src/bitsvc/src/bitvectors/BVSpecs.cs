//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static SFx;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    partial class BV
    {
        [Free, SFx]
        public interface IBvUnaryOp<T> : IUnaryOp<BitVector<T>>
            where T : unmanaged
        {
            T Invoke(T a);
        }

        [Free, SFx]
        public interface IBvBinaryOp<T> : IBinaryOp<BitVector<T>>
            where T : unmanaged
        {
            T Invoke(T a, T b);
        }

        [Free, SFx]
        public interface IBvTernaryOp<T> : ITernaryOp<BitVector<T>>
            where T : unmanaged
        {

            T Invoke(T a, T b, T c);
        }

        [Free, SFx]
        public interface IBvUnaryPred<T> : IFunc<BitVector<T>, Bit32>
            where T : unmanaged
        {
            Bit32 Invoke(T a);
        }

        [Free, SFx]
        public interface IBvBinaryPred<T> : IFunc<BitVector<T>,BitVector<T>,Bit32>
            where T : unmanaged
        {
            Bit32 Invoke(T a, T b);
        }
    }
}