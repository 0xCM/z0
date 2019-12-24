//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public abstract class UnitTest<T> : TestContext<T>, IUnitTest
        where T : UnitTest<T>
    {

        protected UnitTest(ITestConfig config = null)
            : base(config)
            {

            }        
    }
}