//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

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