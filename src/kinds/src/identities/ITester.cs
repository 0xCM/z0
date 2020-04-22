//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface ITester : ITestOptions, ITestCaseIdentity
    {        
        ICheckEquatable Equatable => CheckEquatable.Checker;
    }       
}