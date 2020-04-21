//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public interface IUnitTest : ITestContext 
    {
    }    

    public interface IExplicitTest : IUnitTest, IExecutable
    {
        
    }        
}