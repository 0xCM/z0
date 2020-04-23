//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
        
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

        T eval<K>(T a, K kind = default)
            where K : unmanaged, IBitLogicKind;      

        T eval<K>(T a, T b, K kind = default)
            where K : unmanaged, IBitLogicKind;      

        T eval<K>(T a, T b, T c, K kind = default)
            where K : unmanaged, IBitLogicKind;      
    }
}