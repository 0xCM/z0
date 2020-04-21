//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    public interface ISFCheck : ITestService
    {
        IPolyrand Random => Context.Random;

        void Error(Exception e, [Caller] string caller = null, [File] string file = null, [Line] int? line = null)
            => Context.Deposit(AppMsg.Error(e, caller,file,line));        
    }

    public interface ISFMatch<T,R> : ISFCheck
    {
        void CheckMatch<F,G>(F f, G g)
            where F : ISFuncApi<T,R>
            where G : ISFuncApi<T,R>;        

        void CheckSpanMatch<F,G>(F f, G g)
            where F : ISFuncApi<T,R>
            where G : ISFuncApi<T,R>;        
    }    

    public interface ISFMatch<T0,T1,R> : ISFCheck
    {
        void CheckMatch<F,G>(F f, G g)
            where F : ISFuncApi<T0,T1,R>
            where G : ISFuncApi<T0,T1,R>;        

        void CheckSpanMatch<F,G>(F f, G g)
            where F : ISFuncApi<T0,T1,R>
            where G : ISFuncApi<T0,T1,R>;        
    }

    public interface ISFMatch<T0,T1,T2,R> : ISFCheck
    {
        void CheckMatch<F,G>(F f, G g)
            where F : ISFuncApi<T0,T1,T2,R>
            where G : ISFuncApi<T0,T1,T2,R>;        

        void CheckSpanMatch<F,G>(F f, G g)
            where F : ISFuncApi<T0,T1,T2,R>
            where G : ISFuncApi<T0,T1,T2,R>;        
    }    
}