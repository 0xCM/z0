//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;

    public interface IBitLogic<T>
        where T : struct
    {
        T and(T a, T b);

        T or(T a, T b);

        T xor(T a, T b);

        T nand(T a, T b);

        T nor(T a, T b);

        T xnor(T a, T b);

        T not(T a);

        T select(T a, T b, T c);

        T impl(T a, T b);

        T nonimpl(T a, T b);

        T cimpl(T a, T b);

        T cnonimpl(T a, T b);

        T @true();

        T @false();

        T identity(T a);
    }


}