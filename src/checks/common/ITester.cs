//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    public interface ITester : ITestOptions, IPolyrandProvider, ITestCaseIdentity
    {        
        ICheck Check => ICheck.Checker;

        ICheckEquatable Equatable => ICheckEquatable.Checker;

        ICheckNumeric Numeric => ICheckNumeric.Checker;
    }       
}