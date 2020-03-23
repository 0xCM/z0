//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ISFApiComparer<T1,T2> : ISFComparer
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : ISFApi<T1, T2>
            where G : ISFApi<T1, T2>;        

        void CheckSpan<F, G>(F baseline, G subject)
            where F : ISFApi<T1, T2>
            where G : ISFApi<T1, T2>;        
    }    
}