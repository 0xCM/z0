//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface IFuncComparer : IAppService<ITestContext>
    {
        
    }

    public interface IUnaryFuncComparer<T1,T2> : IFuncComparer
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : IUnaryFunc<T1, T2>
            where G : IUnaryFunc<T1, T2>;        

        void CheckSpan<F, G>(F baseline, G subject)
            where F : IUnaryFunc<T1, T2>
            where G : IUnaryFunc<T1, T2>;        
    }    

    public interface IBinaryFuncComparer<T1,T2,T3> : IFuncComparer
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : IBinaryFunc<T1,T2,T3>
            where G : IBinaryFunc<T1,T2,T3>;        

        void CheckSpan<F, G>(F baseline, G subject)
            where F : IBinaryFunc<T1,T2,T3>
            where G : IBinaryFunc<T1,T2,T3>;        
    }


    public interface ITernaryFuncComparer<T1,T2,T3,T4> : IFuncComparer
    {
        void CheckMatch<F, G>(F baseline, G subject)
            where F : ITernaryFunc<T1,T2,T3,T4>
            where G : ITernaryFunc<T1,T2,T3,T4>;

        void CheckSpan<F, G>(F baseline, G subject)
            where F : ITernaryFunc<T1,T2,T3,T4>
            where G : ITernaryFunc<T1,T2,T3,T4>;        
    }    
}