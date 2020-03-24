//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface ISFMatch : IService<IValidationContext>
    {
        
    }

    public interface ISFMatch<T,R> : ISFMatch
    {
        void Match<F, G>(F reference, G target)
            where F : ISFApi<T, R>
            where G : ISFApi<T, R>;        

        void MatchSpan<F, G>(F reference, G target)
            where F : ISFApi<T, R>
            where G : ISFApi<T, R>;        
    }    

    public interface ISFMatch<T0,T1,R> : ISFMatch
    {
        void Match<F, G>(F reference, G target)
            where F : ISFApi<T0, T1, R>
            where G : ISFApi<T0, T1, R>;        

        void MatchSpan<F, G>(F reference, G target)
            where F : ISFApi<T0, T1, R>
            where G : ISFApi<T0, T1, R>;        
    }

    public interface ISFMatch<T0,T1,T2,R> : ISFMatch
    {
        void Match<F, G>(F reference, G target)
            where F : ISFApi<T0, T1, T2, R>
            where G : ISFApi<T0, T1, T2, R>;

        void MatchSpan<F, G>(F reference, G target)
            where F : ISFApi<T0, T1, T2, R>
            where G : ISFApi<T0, T1, T2, R>;        
    }    
}