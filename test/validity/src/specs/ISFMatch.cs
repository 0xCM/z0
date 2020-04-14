//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface ISFMatch : IService
    {
        
    }

    public interface ISFMatch<T,R> : ISFMatch
    {
        void Match<F, G>(F reference, G target)
            where F : ISFuncApi<T, R>
            where G : ISFuncApi<T, R>;        

        void MatchSpan<F, G>(F reference, G target)
            where F : ISFuncApi<T, R>
            where G : ISFuncApi<T, R>;        
    }    

    public interface ISFMatch<T0,T1,R> : ISFMatch
    {
        void Match<F, G>(F reference, G target)
            where F : ISFuncApi<T0, T1, R>
            where G : ISFuncApi<T0, T1, R>;        

        void MatchSpan<F, G>(F reference, G target)
            where F : ISFuncApi<T0, T1, R>
            where G : ISFuncApi<T0, T1, R>;        
    }

    public interface ISFMatch<T0,T1,T2,R> : ISFMatch
    {
        void Match<F, G>(F reference, G target)
            where F : ISFuncApi<T0, T1, T2, R>
            where G : ISFuncApi<T0, T1, T2, R>;

        void MatchSpan<F, G>(F reference, G target)
            where F : ISFuncApi<T0, T1, T2, R>
            where G : ISFuncApi<T0, T1, T2, R>;        
    }    
}