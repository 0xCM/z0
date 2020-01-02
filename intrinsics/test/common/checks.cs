//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    public static partial class Checks
    {   



    }


    public static partial class CheckSpecs
    {   



    }


    public interface IVChecker128<S,T> : IBinaryPred<S, Vector128<T>>
        where S : unmanaged
        where T : unmanaged
    {
        
    }

    public interface IVChecker256<S,T> : IBinaryPred<S, Vector256<T>>
        where S : unmanaged
        where T : unmanaged
    {
        
    }

    public partial class CheckExec  : UnitTest<CheckExec>
    {
        public CheckExec()
        {
            
        }

        public CheckExec(ITestConfig config)
            : base(config)
        {

        }

        [MethodImpl(NotInline)]
        static void CheckFailed()
            => throw new Exception();

                
        public void CheckFactory<F,C,S,T>(N128 w, F f, C check, S s = default, T t = default)
            where S : unmanaged
            where T : unmanaged
            where F : IVFactoryOp128<S,T>
            where C : IVChecker128<S,T>
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
            where F : IVFactoryOp256<S,T>
            where C : IVChecker256<S,T>
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