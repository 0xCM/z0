//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;


    public abstract class t_vsvc<X> : UnitTest<X>    
        where X : t_vsvc<X>, new()
    {

        protected ICheckNumeric Claim => ICheckNumeric.Checker;

        protected ISVFDecomposer Comparisons {get;}

        protected CheckExec Check {get;}

        protected t_vsvc()
        {
            Check = new CheckExec();
            Comparisons = Context.Decomposer();
        }

    
    }
}
