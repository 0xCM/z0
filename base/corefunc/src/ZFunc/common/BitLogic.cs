//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    public abstract class BitLogic<T> : IBitLogic<T>
        where T : struct
    {
        public abstract T and(T a, T b);

        public abstract T or(T a, T b);

        public abstract T xor(T a, T b);

        public abstract T cimpl(T a, T b);

        public abstract T cnonimpl(T a, T b);

        public abstract T @false();

        public abstract T identity(T a);

        public abstract T impl(T a, T b);

        public abstract T nand(T a, T b);

        public abstract T nonimpl(T a, T b);

        public abstract T nor(T a, T b);

        public abstract T not(T a);

        public abstract T select(T a, T b, T c);

        public abstract T @true();

        public abstract T xnor(T a, T b);

    }
}