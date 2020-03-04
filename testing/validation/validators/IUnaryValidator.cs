//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    public interface IUnaryValidator<T1,T2> : IValidator
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : IUnaryFunc<T1, T2>
            where G : IUnaryFunc<T1, T2>;        

        void CheckSpan<F, G>(F baseline, G subject)
            where F : IUnaryFunc<T1, T2>
            where G : IUnaryFunc<T1, T2>;        
    }
}