//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static Seed;


    public class CheckExec  : UnitTest<CheckExec>
    {
        public CheckExec()
        {
            
        }

        static void CheckFailed()
            => throw new Exception();
                
        public void CheckFactory<F,C,S,T>(N128 w, F f, C check, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
            where F : ISVFactory128Api<S,T>
            where C : ICheckSF128<S,T>
        {
            for(var i=0; i < RepCount; i++)
            {
                var a = Random.Next<S>();
                var v = f.Invoke(a);
                if(!check.Invoke(a,v))
                    CheckFailed();
            }
        }

        public void CheckFactory<F,C,S,T>(N256 w, F f, C check, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
            where F : ISVFactory256Api<S,T>
            where C : ICheckSF256<S,T>
        {
            for(var i=0; i< RepCount; i++)
            {
                var a = Random.Next<S>();
                var v = f.Invoke(a);
                if(!check.Invoke(a,v))
                    CheckFailed();
            }
        }
    }
}