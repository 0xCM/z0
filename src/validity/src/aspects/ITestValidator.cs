//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;
    using static Memories;

    /// <summary>
    /// Root aspect for validators that return validation outcomes in lieu of raising exceptions
    /// </summary>
    public interface ITestValidator : ITestOptions, ITestCaseIdentity, IValidator, IPolyrandContext
    {
        
    }
}