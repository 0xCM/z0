//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface IValidationContext : ITestContext
    {

        string ITestContext.CaseName(ISFuncApi f)
            => Validity.testcase(HostType, f);
    }
}