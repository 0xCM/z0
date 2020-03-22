//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface ITernaryFuncComparer<T1,T2,T3,T4> : IFuncComparer
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : ITernaryFunc<T1, T2, T3, T4>
            where G : ITernaryFunc<T1, T2, T3, T4>;

        void CheckSpan<F, G>(F baseline, G subject)
            where F : ITernaryFunc<T1, T2, T3, T4>
            where G : ITernaryFunc<T1, T2, T3, T4>;        
    }    
}