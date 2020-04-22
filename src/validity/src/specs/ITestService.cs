//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{    
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines a test service which is, by definition, a contextual service of test context kind
    /// </summary>
    public interface ITestService : IService<ITestContext>, ICheckOptions, ITestCaseIdentity, IClocked
    {
        
    }
}