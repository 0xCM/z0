//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    
    using static Seed;
    using static Memories;

    public interface ITestChecker : ITester, ITestResultSink
    {
        
    }
}