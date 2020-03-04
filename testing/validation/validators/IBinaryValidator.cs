//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    
    public interface IBinaryValidator<T1,T2,T3> : IValidator
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : IBinaryFunc<T1,T2,T3>
            where G : IBinaryFunc<T1,T2,T3>;        

        void CheckSpan<F, G>(F baseline, G subject)
            where F : IBinaryFunc<T1,T2,T3>
            where G : IBinaryFunc<T1,T2,T3>;        
    }
}