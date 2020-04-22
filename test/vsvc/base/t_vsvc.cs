//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.Intrinsics;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;


    public abstract class t_vsvc<X> : UnitTest<X>    
        where X : t_vsvc<X>, new()
    {

        protected new ICheckVectors Claim => CheckVectors.Checker;

        protected CheckExec Check {get;}

        protected IVSvcCheck VChecks {get;}
        
        protected t_vsvc()
        {
            Check = new CheckExec();

            VChecks = VSvcCheck.Create(VSvcCheckContext.Create(Context.Decomposer()));
        }

        static void CheckFailed()
            => throw new Exception();
   }
}