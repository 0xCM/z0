//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public interface ITestCase
    {
        string CaseName {get;}        
    }

    public interface ITestCase<C> : ITestCase
        where C: unmanaged, ITestCase<C>
    {
        string ITestCase.CaseName => typeof(C).Name;
    }
}