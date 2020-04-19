//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    public interface IExplicitTest : IUnitTest, IExecutable
    {
        
    }        

    public interface IUnitTest : ITestContext 
    {
    }    

    public interface ITestContext : 
        IServiceAllocation,
        ITestValidator,
        IStopClocks,
        IPolyrandProvider, 
        ICheckAction,
        IService<ITestContext>,         
        ITestQueue
    {
        ICheckNumeric Numeric => ICheckNumeric.Checker;

        ICheckEquatable Equatable => ICheckEquatable.Checker;
    }
}