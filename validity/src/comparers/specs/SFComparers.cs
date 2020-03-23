//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface ISFComparer : IService<IValidationContext>
    {
        
    }

    public interface ISFApiComparer<T1,T2,T3> : ISFComparer
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : ISFApi<T1, T2, T3>
            where G : ISFApi<T1, T2, T3>;        

        void CheckSpan<F, G>(F baseline, G subject)
            where F : ISFApi<T1, T2, T3>
            where G : ISFApi<T1, T2, T3>;        
    }


    public interface ISFApiComparer<T1,T2,T3,T4> : ISFComparer
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : ISFApi<T1, T2, T3, T4>
            where G : ISFApi<T1, T2, T3, T4>;

        void CheckSpan<F, G>(F baseline, G subject)
            where F : ISFApi<T1, T2, T3, T4>
            where G : ISFApi<T1, T2, T3, T4>;        
    }    

    public interface ISFApiBinaryPredicateComparer<T> : ISFApiComparer<T,T,bit>
    {
        
    }        

    public interface ISFApiUnaryOpComparer<T> : ISFApiComparer<T,T>
    {

        
    }

    public interface ISFApiBinaryOpComparer<T> : ISFApiComparer<T,T,T>
    {
        
    }    

}